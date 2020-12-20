# zurich

#Teste desenvolvido em Dotnet Core 3.1, Oracle XE com Visual Studio 2019 Community.

#Ambiente Oracle XE

Foi criada a tabela e a sequence
create table Seguros (
Id              NUMBER,   
valorVeiculo    NUMBER(18,2), 
taxaRisco       NUMBER(18,2),
premioRisco     NUMBER(18,2),
premioPuro      NUMBER(18,2), 
premioComercial NUMBER(18,2),
valorSeguro NUMBER(18,2),
marcaVeiculo varchar2(256),
modeloVeiculo varchar2(256),
Nome varchar2(256),
CPF varchar2(15),
Idade NUMBER
);

CREATE SEQUENCE SEGURO_seq
 START WITH     1
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;
 
 
#2 - Foi realizado o cálculo na classe - ApplicationServiceSeguro
 
 public void Add(SeguroDTO obj)
        {
            try
            {
                var objNew = Mapeador.Mapear<SeguroDTO, Seguro>(obj);

                decimal margemSeguranca = 0.03m;
                decimal lucro = 0.05m;

                objNew.taxaRisco = (objNew.valorVeiculo * 5) / (2 * obj.valorVeiculo);
                objNew.premioRisco = objNew.taxaRisco * objNew.valorVeiculo / 100;
                objNew.premioPuro = objNew.premioRisco * (1 + margemSeguranca);
                objNew.premioComercial = (1+lucro) * objNew.premioPuro;

                objNew.valorSeguro = objNew.premioComercial;

                _serviceSeguro.Add(objNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
# Foi criado na api, o método post e o método api/seguro/cpf para pesquisa do segurado.
  
# Também foi criado um site, com a possibilidade de cadastrar o seguro. 

#Lembrar de alterar

            OracleConfiguration.TraceFileLocation = @"C:\oraclexe\traces";
            OracleConfiguration.TraceLevel = 7;
            OracleConfiguration.TnsAdmin = @"C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN";
           
e as configurações em api.           
           
"OracleConnection": {
    "ConnectionString": "User Id=sysadmin;Password=sysadmin;Data Source=XE;"
}


# Foi inserido swagger

Adicionado o nugget Swashbuckle.AspNetCore

Na api, foi adicionado em build XML documentation file:

C:\sistemas\git\zurich\Seguros.Zurich\Seguros.Zurich.Api\Seguros.Zurich.Api.xml

Em startup no método
public void ConfigureServices(IServiceCollection services)

foi inserido as linhas no final dela

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "O que fazer na API",
                    Description = "Um simples exemplo de ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/spboyer"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            }
            ); 


Ainda no startup no método

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


foi inserido 


            app.UseSwagger();


            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Serguros V1");
            });


Após subir a aplicação o servidor da api, vai subir com um endereço e é só colocar assim

https://localhost:44370/swagger

Irá demonstrar o swagger com todas as apis.
