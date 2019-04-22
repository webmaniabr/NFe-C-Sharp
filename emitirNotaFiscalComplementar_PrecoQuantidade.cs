var client = new RestClient("https://webmaniabr.com/api/1/nfe/complementar/");
var request = new RestRequest(Method.POST);
request.AddHeader("x-access-token-secret", "SEU_ACCESS_TOKEN_SECRET");
request.AddHeader("x-access-token", "SEU_ACCESS_TOKEN");
request.AddHeader("x-consumer-secret", "SEU_CONSUMER_SECRET");
request.AddHeader("x-consumer-key", "SEU_CONSUMER_KEY");
request.AddHeader("content-type", "application/json");
request.AddHeader("cache-control", "no-cache");

request.AddParameter("undefined", "{\n\t\"nfe_referenciada\": \"00000000000000000000000000000000000000000000\",\n\t\"operacao\": 1,\n\t\"natureza_operacao\": \"Natureza da operação\",\n\t\"ambiente\": 2,\n\t\"cliente\": {\n\t\t\"cpf\": \"000.000.000-00\",\n\t\t\"nome_completo\": \"Nome completo\",\n\t\t\"endereco\": \"Av. Brg. Faria Lima\",\n\t\t\"complemento\": \"Escritorio\",\n\t\t\"numero\": 1000,\n\t\t\"bairro\": \"Itaim Bibi\",\n\t\t\"cidade\": \"São Paulo\",\n\t\t\"uf\": \"SP\",\n\t\t\"cep\": \"00000-000\",\n\t\t\"telefone\": \"(00) 0000-0000\",\n\t\t\"email\": \"nome@email.com\"\n\t},\n\t\"produtos\": [{\n\t\t\"nome\": \"Nome do produto\",\n\t\t\"codigo\": \"nome-do-produto\",\n\t\t\"ncm\": \"6109.10.00\",\n\t\t\"cest\": \"28.038.00\",\n\t\t\"quantidade\": 1,\n\t\t\"unidade\": \"UN\",\n\t\t\"origem\": 0,\n\t\t\"subtotal\": \"29.90\",\n\t\t\"total\": \"29.90\",\n\t\t\"impostos\": {\n\t\t\t\"icms\": {\n\t\t\t\t\"codigo_cfop\": \"6.102\",\n\t\t\t\t\"situacao_tributaria\": \"102\"\n\t\t\t}\n\t\t}\n\t}]\n}", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);