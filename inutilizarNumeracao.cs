var client = new RestClient("https://webmaniabr.com/api/1/nfe/inutilizar/");
var request = new RestRequest(Method.PUT);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");

request.AddParameter("undefined", "{\n\t\"sequencia\":\"101-109\",\n\t\"motivo\":\"Inutilização por problemas técnicos.\",\n\t\"ambiente\":\"2\",\n\t\"serie\":\"99\",\n\t\"modelo\":\"1\"\n}", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);