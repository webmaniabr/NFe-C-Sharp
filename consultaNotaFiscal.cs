var client = new RestClient("https://webmaniabr.com/api/1/nfe/consulta/?chave=45150819652219000198550990000000011442380343&ambiente=1");
var request = new RestRequest(Method.GET);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");
IRestResponse response = client.Execute(request);
