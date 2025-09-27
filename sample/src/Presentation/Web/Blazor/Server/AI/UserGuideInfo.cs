using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.AI
{
    public class UserGuideItem
    {
        [VectorStoreRecordKey]
        public long Id { get; set; }

        [Description("user guide's subject)")]
        public List<string> columns = new List<string>();

        [VectorStoreRecordData(IsFilterable = true, IsFullTextSearchable = true)]
        public string JsonData { get; set; }
        public byte[] VectorBody { get; set; } // Store as VARBINARY

        [VectorStoreRecordVector(Dimensions: 3072 /*12288*/, DistanceFunction.CosineDistance, IndexKind.Hnsw)]
        public ReadOnlyMemory<float>? FloatVectorBody { get; set; } // Store as VARBINARY
        public Dictionary<string, string> JsonValues = new();
        [Description("user guide's JsonData")]
        [VectorStoreRecordData(IsFilterable = true)]
        public string Body { get; set; }
    }
    public class UserGuideInfo
    {

        [KernelFunction("get_infos_from_userguide")]
        [Description("extract subject, description, and keywords from the user guide's  body")]
        [return: Description("subject, description, and keywords extracted from user guide")]
        public UserGuideItem GetInfosFromUserGuide([Description("user guide's  body")] UserGuideItem userGuideItem)
        {
            return userGuideItem;
        }
    }
}
