var seguroScript = function () {
    return {
        init: function () {
            recarregarListagem();
            $("#cadastrar").on("click", function (event) {
                event.preventDefault();

                $("#cadastrar").modal('show');
            });

            var viewModel = createVieModel();

            $(".btn-Cadastrar").on("click", cadastrar);
            $(".btn-Editar").on("click", editar);
            $(".btn-Excluir").on("click", excluir);
        }
    }
}();


function createVieModel() {
    var viewModel = {
        Id: 0, 
        valorVeiculo: 0.0,
        taxaRisco: 0.0,
        premioRisco: 0.0,
        premioPuro: 0.0,
        premioComercial: 0.0,
        valorSeguro: 0.0,
        marcaVeiculo: '',
        modeloVeiculo: '',
        Nome: '',
        CPF: '',
        Idade: 0,
    };

    return viewModel;
}

function recarregarListagem() {
    $.ajax({
        type: 'get',
        url: '/Seguro/Listar',
        dataType: 'json',
        beforeSend: function () {
            $('.tabela').empty().append("Carregando...");
        }
    })
        .done(function (data) {
            $('.tab-content').empty().append(data);
            carregaTabela(data);
        })
}

function carregaTabela(data) {
    $('.tabela').empty();

    if (data.length > 0) {


        novaLinha = $('.tabela').append("<tr>");

        var colunaId = novaLinha.append("<td>");
        colunaId.append("Id");

        var colunaValorVeiculo = novaLinha.append("<td>");
        colunaValorVeiculo.append("Valor Veiculo");

        var colunaTaxaRisco = novaLinha.append("<td>");
        colunaTaxaRisco.append("Taxa Risco");

        var colunaPremioRisco = novaLinha.append("<td>");
        colunaPremioRisco.append("Premio Risco");

        var colunaPremioPuro = novaLinha.append("<td>");
        colunaPremioPuro.append("Premio Puro");

        var colunaPremioComercial = novaLinha.append("<td>");
        colunaPremioComercial.append("Premio Comercial");

        var colunaValorSeguro = novaLinha.append("<td>");
        colunaValorSeguro.append("Valor Seguro");

        var colunaMarcaVeiculo = novaLinha.append("<td>");
        colunaMarcaVeiculo.append("Marca Veiculo");

        var colunaModeloVeiculo = novaLinha.append("<td>");
        colunaModeloVeiculo.append("Modelo Veiculo");

        var colunaNome = novaLinha.append("<td>");
        colunaNome.append("Nome");

        var colunaCPF = novaLinha.append("<td>");
        colunaCPF.append("CPF");

        var colunaIdade = novaLinha.append("<td>");
        colunaIdade.append("Idade");

        var colunaTitulo = novaLinha.append("<td colspan='2'>");
        colunaTitulo.append("Ações");
    }

    for (var x = 0; x < data.length; x++) {
        novaLinha = $('.tabela').append("<tr>");

        var colunaId = novaLinha.append("<td>");
        colunaId.append(data[x].id);


        var colunaValorVeiculo = novaLinha.append("<td>");
        colunaValorVeiculo.append(data[x].valorVeiculo);

        var colunaTaxaRisco = novaLinha.append("<td>");
        colunaTaxaRisco.append(data[x].taxaRisco);

        var colunaPremioRisco = novaLinha.append("<td>");
        colunaPremioRisco.append(data[x].premioRisco);

        var colunaPremioPuro = novaLinha.append("<td>");
        colunaPremioPuro.append(data[x].premioPuro);

        var colunaPremioComercial = novaLinha.append("<td>");
        colunaPremioComercial.append(data[x].premioComercial);

        var colunaValorSeguro = novaLinha.append("<td>");
        colunaValorSeguro.append(data[x].valorSeguro);

        var colunaMarcaVeiculo = novaLinha.append("<td>");
        colunaMarcaVeiculo.append(data[x].marcaVeiculo);

        var colunaModeloVeiculo = novaLinha.append("<td>");
        colunaModeloVeiculo.append(data[x].modeloVeiculo);

        var colunaNome = novaLinha.append("<td>");
        colunaNome.append(data[x].nome);

        var colunaCPF = novaLinha.append("<td>");
        colunaCPF.append(data[x].cPF);

        var colunaIdade = novaLinha.append("<td>");
        colunaIdade.append(data[x].idade);

        var colunaEditar = novaLinha.append("<td>");
        colunaEditar.append("<button id='botaoEditar' name='editar' class='btn btn-primary botaoEditar' data-Seguro='" + data[x].id + "' data-toggle='modal' data-target='#editar'>Editar</button>");

        //var colunaExcluir = novaLinha.append("<td>");
        //colunaExcluir.append("<button id='botaoExcluir' name='excluir' class='btn btn-danger botaoExcluir' data-Seguro='" + data[x].id + "' data-toggle='modal' data-target='#excluir'>Excluir</button>");
    }

    $(".botaoEditar").on("click", function (event) {
        event.preventDefault();
        $("#editar").modal('show');

        $.ajax({
            type: 'get',
            url: '/Seguro/ObterId/' + $(this).attr("data-Seguro"),
            dataType: 'json',
            beforeSend: function () {
            }
        })
            .done(function (data) {

                if (data !== null) {
                    $("#Id").val(data.id);

                    $(".editarValorVeiculo").val(data.valorVeiculo);
                    $(".editarTaxaRisco").val(data.taxaRisco);
                    $(".editarPremioRisco").val(data.premioRisco);
                    $(".editarPremioPuro").val(data.premioPuro);
                    $(".editarPremioComercial").val(data.premioComercial);
                    $(".editarValorSeguro").val(data.valorSeguro);
                    $(".editarMarcaVeiculo").val(data.marcaVeiculo);
                    $(".editarModeloVeiculo").val(data.modeloVeiculo);
                    $(".editarNome").val(data.nome);
                    $(".editarCPF").val(data.cpf);
                    $(".editarIdade").val(data.idade);
                }
            });


    });


    $(".botaoExcluir").on("click", function (event) {
        event.preventDefault();

        $("#excluir").modal('show');

        $.ajax({
            type: 'get',
            url: '/Seguro/ObterId/' + $(this).attr("data-Seguro"),
            dataType: 'json',
            beforeSend: function () {
            }
        })
            .done(function (data) {
                if (data !== null) {
                    $("#Id").val(data.id);
                    $(".excluirNome").val(data.nome);
                    $(".excluirBairro").val(data.bairro);
                }
            });


    });
}


function cadastrar(event) {
    var viewModel = createVieModel();

    viewModel.Id = 0;
    viewModel.valorVeiculo = parseFloat($(".cadastrarValorVeiculo").val());
    viewModel.taxaRisco = parseFloat($(".cadastrarTaxaRisco").val());
    viewModel.premioRisco = parseFloat($(".cadastrarPremioRisco").val());
    viewModel.premioPuro = parseFloat($(".cadastrarPremioPuro").val());
    viewModel.premioComercial = parseFloat($(".cadastrarPremioComercial").val());
    viewModel.valorSeguro = parseFloat($(".cadastrarValorSeguro").val());
    viewModel.marcaVeiculo = $(".cadastrarMarcaVeiculo").val();
    viewModel.modeloVeiculo = $(".cadastrarModeloVeiculo").val();
    viewModel.Nome = $(".cadastrarNome").val();
    viewModel.CPF = $(".cadastrarCPF").val();
    viewModel.Idade = parseInt($(".cadastrarIdade").val());

    var data = JSON.stringify(viewModel);

    $.ajax({
        type: 'post',
        url: '/Seguro/Cadastrar',
        data,
        contentType: 'application/json',
        beforeSend: function () {

        }
    }).done(function (data) {
        recarregarListagem();
        $("#cadastrar").modal('hide');
    });
}

function editar(event) {
    var viewModel = createVieModel();

    var id = parseInt($("#Id").val());
    viewModel.Id = isNaN(id) ? 0 : id;


    viewModel.valorVeiculo = parseFloat($(".editarValorVeiculo").val());
    viewModel.taxaRisco = $(".editarTaxaRisco").val();
    viewModel.premioRisco = $(".editarPremioRisco").val();
    viewModel.premioPuro = $(".editarPremioPuro").val();
    viewModel.premioComercial = $(".editarPremioComercial").val();
    viewModel.valorSeguro = $(".editarValorSeguro").val();
    viewModel.marcaVeiculo = $(".editarMarcaVeiculo").val();
    viewModel.modeloVeiculo = $(".editarModeloVeiculo").val();
    viewModel.Nome = $(".editarNome").val();
    viewModel.CPF = $(".editarCPF").val();
    viewModel.Idade = $(".editarIdade").val();

    var data = JSON.stringify(viewModel);

    $.ajax({
        url: '/Seguro/Atualizar/',
        type: "PUT",
        data,
        contentType: 'application/json',
        success: function (data) {
            recarregarListagem();
            $("#editar").modal('hide');
        },
        error: function (data) {

        }
    });
}



function excluir(event) {
    var id = parseInt($("#Id").val());

    $.ajax({
        type: 'post',
        url: '/Seguro/Remover/' + id,
        contentType: 'application/json',
        beforeSend: function () {

        }
    }).done(function (data) {
        recarregarListagem();
        $("#excluir").modal('hide');
    });
}