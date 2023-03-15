using Newtonsoft.Json;

namespace ExpandedSearchInfoTemp.Configs {
    public class FListConfig : BaseConfig {
        [JsonConstructor]
        public FListConfig() {
            this.Enabled = false;
        }
    }
}
