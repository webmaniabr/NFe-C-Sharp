var client = new RestClient("https://webmaniabr.com/api/1/nfe/cartacorrecao/");
var request = new RestRequest(Method.POST);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");

request.AddParameter("undefined", "{\n\t\"chave\": \"00000000000000000000000000000000000000000000\",\n\t\"correcao\": \"O CFOP correto é 5.102 referente a revenda tributada no mesmo estado.\"\n}", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);