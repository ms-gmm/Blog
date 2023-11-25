using Nest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace Blog.Common
{
    public class ESUtil<T>
    {
        //public static string conn = ConfigurationManager.AppSettings["eshost"];
        public static string conn = "http://192.168.179.110:9200";

        /// <summary>
        /// 索引名称,使用什么？ 
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="initDatas"></param>
        public static void CreatIndex(string indexName, IEnumerable<T> initDatas)
        {

            var node = new Uri("http://wdora.com:9200");
            var setting = new ConnectionSettings(node);
            var esClient = new ElasticClient(setting);

            esClient.Index(initDatas, idx => idx.Index(indexName));//没有会为你创建一个user1索引，往里加数据
            //esClient.Index(initDatas, idx => idx.Index("user1"));//直接加数据
            //var data1 = esClient.Search<User>(o => o.Index("user1")).Documents;
        }
    }
}
