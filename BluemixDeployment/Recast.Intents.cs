using BluemixDeployment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace RecastAI
{
    class Base
    {
        /*public Base(string stoken)
        {
            _token = stoken;
        }

        public string _sUrlRecast = "https://api.recast.ai";
        public string _token { get; set; }*/

        public string _json { get; set; }
        public string _message { get; set; }
        //public string _uri { get; set; }
    }
    
    class User
    {
        public User(string sSlug)
        {
            slug = sSlug;
        }

        public User(dynamic json)
        {
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            nickname = json.nickname;
            slug = json.slug;            
            image = json.image;
            email = json.email;          
        }

        public string url_recast = "https://api.recast.ai";

        public string id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string slug { get; set; }
        public string image { get; set; }

        public string email { get; set; }

        public string uri
        {
            get
            {
                return url_recast + "/v2/users/" + slug;
            }
        }

    }

    class Action : Base
    {

        public void Load(dynamic json)
        {
            slug = json.slug;
            done = json.done;
            reply = json.reply;
        }

        public string slug { get; set; }
        public bool done { get; set; }
        public string reply { get; set; }
        
    }
       
    class Conversation : Base
    {

        public Conversation()
        {
            replies = new List<string>();
            entities = new List<Entity>();
            intents = new List<Intent>();
        }

        public Conversation(string sConvToken)
        {
            conversation_token = sConvToken;
            replies = new List<string>();
            entities = new List<Entity>();
            intents = new List<Intent>();
        }

        public void Load(dynamic json)
        {
            uuid = json.uuid;
            source = json.source;
            //Replies
            replies.Clear();
            if (null != json.replies)
            {
                var vReplies = (JArray)json.replies;
                foreach (string elem in vReplies)
                {
                    replies.Add(elem);
                }
            }

            action = new Action();
            if (null != json.action)
                action.Load(json.action);


            //Entities
            entities.Clear();
            if (null != json.entities)
            {
                var vEntities = (JArray)json.entities;
                foreach (var elem in vEntities)
                {
                    entities.Add(new Entity(elem));
                }
            }

            sentiment = json.sentiment;

            //Intents
            intents.Clear();
            if (null != json.intents)
            {
                var vIntents = (JArray)json.intents;
                foreach (var elem in vIntents)
                {
                    intents.Add(new Intent(elem));
                }
            }

            conversation_token = json.conversation_token;
            language = json.language;
            processing_language = json.processing_language;
            timestamp = json.timestamp;
            version = json.version;
            status = json.status ?? 0;
        }

        public JObject GetJson()
        {
            JObject rss = new JObject(
                new JProperty("text", source),
                new JProperty("language", language),
                new JProperty("conversation_token", conversation_token)
                );

            return rss;
        }

        public void Converse(Bot oBot, string sText, string sConvToken = null)
        {            
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.user.url_recast + "/v2/converse", "POST", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
            _json = ret._json.ToString();
            Load(ret._json);
        }

        public string uuid { get; set; }
        public string source { get; set; }
        public List<string> replies { get; set; }
        public Action action { get; set; }
        public List<Entity> entities { get; set; }
        public string sentiment { get; set; }
        public List<Intent> intents { get; set; }
        public string conversation_token { get; set; }
        public string language { get; set; }
        public string processing_language { get; set; }
        public string timestamp { get; set; }
        public string version { get; set; }
        public int status { get; set; }       
    }

    class Bot : Base
    {
        public Bot(User oUser, string sId, string sName, string sSlug, string sReqToken,string sDevToken)
        {
            user = oUser;
            id = sId;
            name = sName;
            slug = sSlug;
            request_token = sReqToken;
            developer_token = sDevToken;

            intents = new List<Intent>();
        }

        public Bot(User oUser, dynamic json)
        {
            user = oUser;
            intents = new List<Intent>();
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            slug = json.slug;
            description = json.description;
            _public = json.@public;
            strictness = json.strictness;
            request_token = json.request_token;
            developer_token = json.developer_token;
            children_count = json.children_count;
            intents_count = json.intents_count ?? 0;
            gazettes_count = json.gazettes_count ?? 0;
            logs_count = json.logs_count ?? 0;

            //Intents
            intents.Clear();
            var vIntents = (JArray)json.intents;
            foreach (var elem in vIntents)
            {
                intents.Add(new Intent(elem));
            }

            if (null != json.user)
                user = new User(json.user);

            if (null != json.language)
                language = new Language(json.language);

            _json = json.ToString();
        }

        public JObject GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("description", description),
                new JProperty("strictness", strictness),
                new JProperty("public", _public),
                new JProperty("language", language.GetJson())
                );
            
            return rss;
        }

        public string id { get; set; }
        public string name { get; set; }

        public string slug { get; set; }
        public string description { get; set; }
        public bool _public { get; set; }
        public int strictness { get; set; }
        public string request_token { get; set; }
        public string developer_token { get; set; }

        public string children_count { get; set; }

        public int intents_count { get; set; }

        public int gazettes_count { get; set; }

        public int logs_count { get; set; }
        public bool is_privatisable { get; set; }

        public Bot parent { get; set; }
        public List<Intent> intents { get; set; }
        //actions Array of Action The bot light actions
        //gazettes Array of Gazette    The bot light gazettes
        public Language language { get; set; }
        public User user { get; set; }

        public string uri
        {
            get
            {
                if(!string.IsNullOrEmpty(slug))
                    return user.uri + "/bots/"+ slug;
                if (!string.IsNullOrEmpty(id))
                    return user.uri + "/bots/" + id;

                return user.uri + "/bots/";
            }            
        }
        public static Bot Get(User oUser, string sSlug, string sDevToken)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oUser.uri + "/bots/" + sSlug, "GET", null, 0, null, null, null, sDevToken, "Token");
            Bot oBot = new Bot(oUser,ret._json.results);
            oBot._message = ret._json.message;

            return oBot;
        }

        public void Update()
        {
            Tools.HttpReturn ret = Tools.HttpRequest(uri, "PUT", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, developer_token, "Token");
            _json = ret._json.ToString();
            Load(ret._json.results);
        }

        public void AnalyzeText(string sText)
        {
            JObject rss = new JObject(new JProperty("text", sText));
            Tools.HttpReturn ret = Tools.HttpRequest(user.url_recast + "/v2/request", "POST", Encoding.UTF8.GetBytes(rss.ToString()), 0, "application/json", null, null, developer_token, "Token");
            _json = ret._json.ToString();
        }
    }

    class Intent : Base
    {
        public Intent(string sId, string sSlug=null)
        {
            expressions = new List<Expression>();
            id = sId;
            slug = sSlug;
        }

        public Intent(dynamic json)
        {
            expressions = new List<Expression>();
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            slug = json.slug;
            description = json.description;
            is_activated = json.is_activated;
            position = json.position ?? 0;
            expressions_count = json.expressions_count ?? 0;
            logs_count = json.logs_count ?? 0;

            if (null != json.expressions)
                LoadExpressions(json.expressions);
        }

        private void LoadExpressions(dynamic json)
        {
            //Expressions
            expressions.Clear();
            //var exps = (JArray)json.expressions;
            foreach (var elem in json)
            {
                expressions.Add(new Expression(elem));
            }
        }

        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }

        public bool is_activated { get; set; }
        public int position { get; set; }

        public int expressions_count { get; set; }
        public int logs_count { get; set; }

        public List<Expression> expressions { get; set; }

        public JObject GetJson(bool b = true)
        {
            JObject rss = null;
            if (b)
            {
                rss = new JObject(
                    new JProperty("name", name),
                    new JProperty("description", description));

                if (expressions.Count > 0)
                {
                    JArray oArray = new JArray();
                    foreach (Expression xp in expressions)
                    {
                        oArray.Add(xp.GetJson());
                    }
                    rss.Add(new JProperty("expressions", oArray));
                }
            }
            else
            {
                
                JArray oArray = new JArray();
                if (expressions.Count > 0)
                {
                    foreach (Expression xp in expressions)
                    {
                        oArray.Add(xp.GetJson());
                    }
                }
                rss = new JObject(new JProperty("expressions", oArray));

            }    
                      
            return rss;
        }

        public void AddExpressions(string sFileName)
        {
            foreach (string line in  File.ReadLines(sFileName))
            {
                string[] tab = line.Split(",".ToCharArray());

                expressions.Add(new Expression(tab[0], tab[1]));
            }
        }

        public void GetListExpressions(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + id + "/expressions", "GET", null, 0, null, null, null, oBot.developer_token,"Token");
            _json = ret._json.ToString();
            LoadExpressions(ret._json.results);
            /*var exps = (JArray)ret._json.results;
            foreach (var elem in exps)
            {
                expressions.Add(new Expression(elem));
            }*/
        }

        public void Get(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + id, "GET", null, 0, null, null, null, oBot.developer_token, "Token");
            _json = ret._json.ToString();
            Load(ret._json);           
        }

        public void Create(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents", "POST", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
            _json = ret._json.ToString();

            var exps = (JArray)ret._json.results;
            foreach (var elem in exps)
            {
                expressions.Add(new Expression(elem));
            }
        }

        public void BulkCreateExpressions(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + id + "/expressions/bulk_create", "POST", Encoding.UTF8.GetBytes(GetJson(false).ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
            _json = ret._json.ToString();
        }

        public void Update(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + id , "PUT", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
            _json = ret._json.ToString();

            var exps = (JArray)ret._json.results;
            foreach (var elem in exps)
            {
                expressions.Add(new Expression(elem));
            }
        }

        public void Delete(Bot oBot)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + id, "DELETE", null, 0, null, null, null, oBot.developer_token, "Token");
        }

    }

    class Entity : Base
    {
        /*"id": "6507c8ab-3271-5b2a-8ece-a5cb51151651",
       "name": "WEB-PAGES",
       "slug": "web-pages",
       "color": "#26a69a",
       "custom": true,
       "count": 1*/

        public Entity(dynamic json)
        {
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            slug = json.slug;
            color = json.color;
            custom = json.custom ?? false;
            count = json.count ?? 0;
        }

        public JObject GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("color", color),
                new JProperty("custom", custom)
                );

            return rss;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string color { get; set; }
        public bool custom { get; set; }

        public int count { get; set; }
    }

    class Expression : Base
    {
        public Expression(dynamic json)
        {
            tokens = new List<Token>();
            Load(json);
        }

        public Expression(string sId)
        {
            id = sId;
        }

        public Expression(string sSource, string sIsocode)
        {
            source = sSource;
            language = new Language(sIsocode);
        }

        public Expression(string sId,string sSource, string sIsocode)
        {
            id = sId;
            source = sSource;
            language = new Language(sIsocode);
        }
        public void Load(dynamic json)
        {
            id = json.id;
            source = json.source;

            //Tokens
            tokens.Clear();
            if (null != json.tokens)
            {
                var vTokens = (JArray)json.tokens;
                foreach (var elem in vTokens)
                {
                    tokens.Add(new Token(elem));
                }
            }

            //Language
            if (null != json.language)
                language = new Language(json.language);
        }

        public JObject GetJson()
        {
            JObject rss = new JObject(
                new JProperty("source", source),
                new JProperty("language", language.GetJson())
                );

            
            return rss;
        }


        public string id { get; set; }
        public string source { get; set; }
        public List<Token> tokens { get; set; }
        public Language language { get; set; }

        public void Get(Bot oBot, string sIntentId)
        {
            if (!string.IsNullOrEmpty(sIntentId))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + sIntentId + "/expressions/" + id, "GET", null, 0, null, null, null, oBot.developer_token, "Token");
                _json = ret._json.ToString();
                Load(ret._json.results);
            }
        }

        public void Create(Bot oBot, string sIntentId)
        {
            if (!string.IsNullOrEmpty(sIntentId))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + sIntentId + "/expressions", "POST", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
                _json = ret._json.ToString();
                Load(ret._json.results);
            }
        }

        public void Update(Bot oBot, string sIntentId)
        {
            if (!string.IsNullOrEmpty(sIntentId))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + sIntentId + "/expressions/"+id, "PUT", Encoding.UTF8.GetBytes(GetJson().ToString()), 0, "application/json", null, null, oBot.developer_token, "Token");
                _json = ret._json.ToString();
                Load(ret._json.results);
            }
        }

        public void Delete(Bot oBot, string sIntentId)
        {
            if (!string.IsNullOrEmpty(sIntentId))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(oBot.uri + "/intents/" + sIntentId + "/expressions/" + id, "DELETE", null, 0, null, null, null, oBot.developer_token, "Token");
                _json = ret._json.ToString();
            }
        }
    }

    class Word
    {
        public Word(dynamic json)
        {
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            slug = json.slug;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    class Token
    {
        public Token(dynamic json)
        {
            Load(json);
        }

        public void Load(dynamic json)
        {
            id = json.id;
            space = json.space;
            
            //Word
            if (null != json.word)
                word = new Word(json.word);

            //Entity
            if (null != json.entity)
                entity = new Entity(json.entity);
        }

        public string id { get; set; }
        public bool space { get; set; }
        public Word word { get; set; }
        public Entity entity { get; set; }
    }

    class Language
    {
        public Language(dynamic json)
        {
            Load(json);
        }

        public Language(string sIsocode)
        {
            isocode = sIsocode;
        }

        public void Load(dynamic json)
        {
            id = json.id;
            name = json.name;
            slug = json.slug;
            isocode = json.isocode;
            support = json.support;
        }

        public JObject GetJson()
        {
            JObject rss = new JObject(new JProperty("isocode", isocode));                       
            return rss;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string isocode { get; set; }
        public string support { get; set; }
        //public bool is_supported { get; set; }
    }
}
