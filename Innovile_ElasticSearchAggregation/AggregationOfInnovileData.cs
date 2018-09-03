using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nest;
using Elasticsearch.Net;

namespace Innovile_ElasticSearchAggregation
{
    class AggregationOfInnovileData
    {
        public long totalCount = 0;
        public long totalSearchTime = 0;
        private ElasticClient elasticClient;
        private ConnectionSettings connectionSettings;

        public AggregationOfInnovileData() { }

        public AggregationOfInnovileData(string portLocation, string indexName, string typeName)
        {

            connectionSettings = new ConnectionSettings(new Uri(portLocation));
            elasticClient = new ElasticClient(connectionSettings);

            connectionSettings.DefaultIndex(indexName);//index name(database name)
            connectionSettings.DefaultTypeName(typeName);//type name(table name)
        }

        public List<KeyedBucket<string>> RNCName(int size, string startDate, string endDate)
        {
            var resultRNCName = elasticClient.Search<DataFields>(s => s
                    .Size(0)
                    .Query(q => q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate.ToString())
                                                                .LessThan(endDate.ToString())))
                    .Aggregations(ags => ags.Terms("rncname", asd => asd.Field("RNCName.keyword")
                                                                        .Size(size)
                                                                        .Order(o => o.Descending("_term"))
                    )));
            totalSearchTime += resultRNCName.Took;
            var res = resultRNCName.Aggregations.Terms("rncname").Buckets.ToList();
            return res;
        }
        public List<KeyedBucket<string>> LocalCellName(int size, string value, string startDate, string endDate)
        {
            var resultLocalCellName = elasticClient.Search<DataFields>(s => s
               .Size(0)
               .Query(q => q.Term(t => t.Field("RNCName.keyword").Value(value)) &&
                           q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate.ToString())
                                                                .LessThan(endDate.ToString())))
               .Aggregations(ags => ags.Terms("localcellname", d => d.Field("Local_cell_name.keyword")
                                                          .Size(size)
                                                          .Order(o => o.Descending("_term")))));
            totalSearchTime += resultLocalCellName.Took;
            var res = resultLocalCellName.Aggregations.Terms("localcellname").Buckets.ToList();
            return res;
        }
        public List<DateHistogramBucket> SDate(string valueSehir, string valueAdSoyad, string interval, int minDocCount, string startDate, string endDate)
        {
            var resultSDate = elasticClient.Search<DataFields>(s => s
                     .Size(0)
                     .Query(q => q.Term(t => t.Field("RNCName.keyword").Value(valueSehir)) &&
                                 q.Term(tr => tr.Field("Local_cell_name.keyword").Value(valueAdSoyad)) &&
                                 q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate.ToString())
                                                                .LessThan(endDate.ToString())))
                     .Aggregations(ags => ags.DateHistogram("sdate", d => d.Field("SDATE")
                                                                             .Interval(interval)
                                                                             .MinimumDocumentCount(minDocCount)))
                                                                            //.TimeZone("+03:00")))
                    );
            totalSearchTime += resultSDate.Took;
            var res = resultSDate.Aggregations.DateHistogram("sdate").Buckets.ToList();
            return res;
        }
        public List<string> ResultAvg(string valueRNCName, string valueLocalCellName, string startDate, string endDate)//burasyı düzelt
        {
            List<string> lst = new List<string>();
            try
            {
                var resultColumns22 = elasticClient.Search<DataFields>(s => s
                        .Size(0)
                        .Query(q => q.Exists(e => e.Field(f => f.column22))&&
                                    q.Term(t => t.Field("RNCName.keyword").Value(valueRNCName)) &&
                                    q.Term(t => t.Field("Local_cell_name.keyword").Value(valueLocalCellName)) &&
                                    q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate)
                                                                    .LessThan(endDate)))
                         .Aggregations(ag => ag.Average("12", d => d.Field("column22"))
                                                .Average("13", d => d.Field("column23"))
                                                .Average("14", d => d.Field("column24"))
                                                .Average("15", d => d.Field("column25"))
                                                .Average("16", d => d.Field("column26"))
                                                .Average("17", d => d.Field("column27"))
                                                .Average("18", d => d.Field("column28"))
                                                .Average("19", d => d.Field("column29"))
                                                .Average("20", d => d.Field("column30"))
                                                .Average("21", d => d.Field("column31"))
                          ));
                totalSearchTime += resultColumns22.Took;
                var resultColumns32 = elasticClient.Search<DataFields>(s => s
                        .Size(0)
                        .Query(q => q.Exists(e => e.Field(f => f.column34)) &&
                                    q.Term(t => t.Field("RNCName.keyword").Value(valueRNCName)) &&
                                    q.Term(t => t.Field("Local_cell_name.keyword").Value(valueLocalCellName)) &&
                                    q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate)
                                                                    .LessThanOrEquals(endDate)))
                         .Aggregations(ag => ag.Average("20", d => d.Field("column32"))
                                               .Average("21", d => d.Field("column33"))
                                               .Average("21", d => d.Field("column34"))
                          ));
                totalSearchTime += resultColumns32.Took;
                var resultAVG = elasticClient.Search<DataFields>(s => s
                        .Size(0)
                        .Query(q => q.Term(t => t.Field("RNCName.keyword").Value(valueRNCName)) &&
                                    q.Term(t => t.Field("Local_cell_name.keyword").Value(valueLocalCellName)) &&
                                    q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate)
                                                                    .LessThanOrEquals(endDate)))
                        .Aggregations(ag => ag.Average("1", d => d.Field("H3G_1526727293"))
                                              .Average("2", d => d.Field("H3G_1526727294"))
                                              .Average("3", d => d.Field("H3G_1526727295"))
                                              .Average("4", d => d.Field("H3G_1526728173"))
                                              .Average("5", d => d.Field("H3G_1526728355"))
                                              .Average("6", d => d.Field("H3G_1526728356"))
                                              .Average("7", d => d.Field("H3G_1526728878"))
                                              .Average("8", d => d.Field("H3G_1526728888"))
                                              .Average("9", d => d.Field("H3G_1526728908"))
                                              .Average("10", d => d.Field("H3G_1526728952"))
                                              .Average("11", d => d.Field("H3G_1526728953"))
                        ));
                totalSearchTime += resultAVG.Took;
                foreach (var i in resultAVG.Aggregations)
                {
                    lst.Add(resultAVG.Aggregations.Average(i.Key.ToString()).Value.ToString());
                }
                foreach (var i in resultColumns22.Aggregations)
                {
                    lst.Add(resultColumns22.Aggregations.Average(i.Key.ToString()).Value.ToString());
                }
                foreach (var i in resultColumns32.Aggregations)
                {
                    lst.Add(resultColumns32.Aggregations.Average(i.Key.ToString()).Value.ToString());
                }
                return lst;
            }
            catch (Exception ex) { }

            return lst;
        }
        public string QueryCount(string valueSehir, string valueAdSoyad, string startDate, string endDate)
        {
            var resultCount = elasticClient.Count<DataFields>(s => s
                    .Query(q => q.Term(t => t.Field("RNCName.keyword").Value(valueSehir)) &&
                                q.Term(t => t.Field("Local_cell_name.keyword").Value(valueAdSoyad)) &&
                                q.DateRange(t => t.Field("SDATE").GreaterThanOrEquals(startDate)
                                                                .LessThan(endDate))));
            totalCount += resultCount.Count;
            var res = resultCount.Count.ToString();

            return res;
        }
        public int DitinctValueCountOfField(string fieldName)
        {
            var response = elasticClient.Search<DataFields>(s => s
             .Size(0)
             .Aggregations(x => x.Cardinality("distinct", c => c.Field(fieldName)))
              );

            var result = response.Aggregations.Cardinality("distinct").Value;
            return Convert.ToInt32(result);
        }
    }
}