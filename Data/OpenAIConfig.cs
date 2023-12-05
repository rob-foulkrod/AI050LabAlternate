namespace AI050LabAlternate.Data
{
    public class OpenAIConfig
    {
        public string DeploymentName{ get; set; }
        public string Version { get; set; }
        public string SearchEndpoint { get; set; }
        public string SearchKey { get; set; }
        public string SearchIndexName { get; set; }

        public bool SearchConfigured => !string.IsNullOrEmpty(SearchEndpoint) && !string.IsNullOrEmpty(SearchKey) && !string.IsNullOrEmpty(SearchIndexName);
    }
}
