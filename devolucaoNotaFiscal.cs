/*
JSON request:

{
  "chave": "45150819652219000198550990000000011442380343",
  "natureza_operacao": "Devolução de venda de produção do estabelecimento",
  "codigo_cfop": "1.202",
  "produtos": [ 2, 3 ],
  "ambiente": "1"
}
*/

var client = new RestClient("https://webmaniabr.com/api/1/nfe/devolucao/");
var request = new RestRequest(Method.POST);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");
request.AddParameter("application/json", "{\"chave\":\"45150819652219000198550990000000011442380343\",\"natureza_operacao\":\"Devolução de venda de produção do estabelecimento\",\"codigo_cfop\":\"1.202\",\"produtos\": [ 2, 3 ],\"ambiente\":\"1\"}", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
