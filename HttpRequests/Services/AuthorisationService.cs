namespace HttpRequests.Services
{
    public class AuthorisationService
    {
        private readonly string _url;
        private readonly Configuration _configuration;
        private readonly HttpService _httpService;
        private readonly ConfigurationService _configurationService;

        public AuthorisationService()
        {
            _configurationService = new ConfigurationService();
            _httpService = new HttpService();

            _configuration = _configurationService.ReadConfig();
        }
    }
}
