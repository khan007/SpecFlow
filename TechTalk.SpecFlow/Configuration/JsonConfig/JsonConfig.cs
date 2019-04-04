using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TechTalk.SpecFlow.Configuration.JsonConfig
{
    public class JsonConfig
    {
        //[JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "language")]
        public LanguageElement Language { get; set; }

        //[JsonProperty("bindingCulture", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "bindingCulture")]
        public BindingCultureElement BindingCulture { get; set; }

        //[JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "runtime")]
        public RuntimeElement Runtime { get; set; }

        //[JsonProperty("generator", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "generator")]
        public GeneratorElement Generator { get; set; }


        //[JsonProperty("trace", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "trace")]
        public TraceElement Trace { get; set; }

        //[JsonProperty("stepAssemblies", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "stepAssemblies")]
        public List<StepAssemblyElement> StepAssemblies { get; set; }
    }
}