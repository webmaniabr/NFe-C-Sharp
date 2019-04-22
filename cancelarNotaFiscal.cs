var client = new RestClient("https://webmaniabr.com/api/1/nfe/cancelar/");
var request = new RestRequest(Method.PUT);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");

request.AddParameter("undefined", "{\n\t\"chave\":\"00000000000000000000000000000000000000000000\",\n\t\"motivo\":\"Cancelamento por motivos administrativos.\"\n}", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);