var client = new RestClient("https://webmaniabr.com/api/1/nfe/ajuste/");
var request = new RestRequest(Method.POST);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");

request.AddParameter("undefined", "{\n\"operacao\": 1,\n\"natureza_operacao\": \"CREDITO ICMS S/ ESTOQUE\", \n\"codigo_cfop\": 2.949,\n\"valor_icms\": 1000.00,\n\"ambiente\": 2,\n\"cliente\": {\n    \"cpf\" : \"000.000.000-00\",\n    \"nome_completo\" : \"Nome completo\",\n    \"endereco\" : \"Av. Brg. Faria Lima\",\n    \"complemento\" : \"Escritório\",\n    \"numero\" : 1000,\n    \"bairro\" : \"Itaim Bibi\",\n    \"cidade\" : \"São Paulo\",\n    \"uf\" : \"SP\",\n    \"cep\" : \"00000-000\",\n    \"telefone\" : \"(00) 0000-0000\",\n    \"email\" : \"nome@email.com\"\n  }\n}\n", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);