using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class Tools
    {
        public class HttpReturn
        {
            public MemoryStream _Data { get; set; }
            public WebHeaderCollection _Headers { get; set; }
            public dynamic _json { get; set; }
        }

        static public HttpReturn HttpRequest(string sUrl, string sHttpMethod, byte[] oDataRequest, long iSizeData, string sContentType, string sUser, string sPwd, string sToken, string sTokenType = null)
        {

            //Création de la requête Http à partir de l'url passée en paramètre
            HttpWebRequest _oRequest = (HttpWebRequest)WebRequest.Create(sUrl);
            _oRequest.Method = sHttpMethod;
            _oRequest.Timeout = 30000;
            //_oRequest.KeepAlive = false;

            //Si un User local et un pwd sont renseignés
            if ((!String.IsNullOrEmpty(sUser)) && (!String.IsNullOrEmpty(sPwd)))
            {
                
                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(sUser + ":" + sPwd));
                _oRequest.Headers.Add("Authorization", "Basic " + authToken);
                
            }
            else if (!String.IsNullOrEmpty(sToken))
            {
                if (!String.IsNullOrEmpty(sTokenType))
                    _oRequest.Headers.Add("Authorization", sTokenType + " " + sToken);
                else
                    _oRequest.Headers.Add("Authorization", "bearer " + sToken);

            }

            //Ajout du ContentType si besoin
            if (!String.IsNullOrEmpty(sContentType))
            {
                _oRequest.ContentType = sContentType;
            }

            //requête nécessitant de passer des données en entrée
            if (oDataRequest != null)
            {
                Stream _oPostData = _oRequest.GetRequestStream();
                _oPostData.Write(oDataRequest, 0, oDataRequest.Length);
                _oPostData.Close();
            }

            try
            {
                //if (IsHttps)
                //    _oRequest.ServerCertificateValidationCallback = ValidateRemoteCertificate;

                WebResponse _oResponse = _oRequest.GetResponse();
                HttpStatusCode _oHttpCode = ((HttpWebResponse)_oResponse).StatusCode;
                HttpReturn ret = new HttpReturn();

                if ((HttpStatusCode.OK == _oHttpCode)|| (HttpStatusCode.Created == _oHttpCode))
                {
                    /*foreach (string skey in _oResponse.Headers.AllKeys)
                    {
                        tbLog.Text = tbLog.Text + skey + " : " + _oResponse.Headers[skey] + "\r\n";
                    }*/
                                        
                    //récupération des données à partir du Stream retourné par le WebResponse               
                    ret._Data = DownloadData(_oResponse);
                    if (_oResponse.ContentType.Contains("application/json"))
                        ret._json = JObject.Parse(Encoding.UTF8.GetString(ret._Data.ToArray()));

                    ret._Headers = _oResponse.Headers;
                }

                return ret;
            }
            catch (WebException Wex)
            {
                string sErrMsg = Wex.Message;
                throw new Exception(sErrMsg, Wex);
            }
        }

        static public MemoryStream DownloadData(WebResponse oRes)
        {
            MemoryStream _oMemoryStream = null;

            using (Stream _oStream = (Stream)oRes.GetResponseStream())
            {
                // récupération en mémoire du Stream contenant les données
                _oMemoryStream = new MemoryStream();

                int _iNbByte = 1;
                byte[] _Buffer = new byte[4096];

                do
                {
                    _iNbByte = _oStream.Read(_Buffer, 0, _Buffer.Length);
                    _oMemoryStream.Write(_Buffer, 0, _iNbByte);
                } while (_iNbByte != 0);

                //Important : remise à 0 de l'indice de position sinon les Read ne fonctionneront pas (et pas d'exception retournée ...)
                _oMemoryStream.Position = 0;
            }
            return _oMemoryStream;
        }
    }
}
