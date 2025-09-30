using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos",Inferencia.Executar },
                {"Interpolação - Fundamentos",Interpolacao.Executar },
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Número - Fundamentos",FormatandoNumero.Executar },
                {"Conversões - Fundamentos",Conversoes.Executar },
                {"Operações Aritméticos - Fundamentos",OperacoesAritmeticos.Executar },
                {"Operações Relacionais - Fundamentos",OperacoesRelacionais.Executar },
                {"Operações Lógicos - Fundamentos",OperadoresLogicos.Executar },
                {"Operações Atribuição - Fundamentos",OperadoresAtribuicao.Executar },
                {"Operações Unários - Fundamentos",OperadoresUnarios.Executar },
                {"Operador Tenários - Fundamentos",OperadorTernario.Executar },

                //Estrutura de Controle
                {"Estrutura IF - Estruturas de Controle",EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle",EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estruturas de Controle",EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle",EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle",EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle",EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle",EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle",UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle",UsandoContinue.Executar },
                
                // Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar },
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos",AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos",DesafioAtributo.Executar },
                {"Params - Classes e Métodos",Params.Executar },
                {"Parametros Nomeados - Classes e Métodos",ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos",GetSet.Executar },
                {"Props - Classes e Métodos",Props.Executar },
                {"Readonly - Classes e Métodos",Readonly.Executar },
                {"Enum - Classes e Métodos",ExemploEnum.Executar },
                {"Struct - Classes e Métodos",ExemploStruct.Executar },
                {"Struct VS Classe - Classes e Métodos",StructVsClasse.Executar },
                {"Valor VS Referencia - Classes e Métodos",ValorVsReferencia.Executar },
                {"Parametros Por Referencia - Classes e Métodos",ParametrosPorReferencia.Executar },
                {"Parametros com Valor Padrão - Classes e Métodos",ParametroPadrao.Executar },

                // Coleções
                {"Array - Coleções",Colecoes.Array.Executar },
                {"List - Coleções",ColecoesList.Executar },
                {"ArrayList - Coleções",ColecoesArrayList.Executar },
                {"Set - Coleções",ColecoesSet.Executar },
                {"Queue - Coleções",ColecoesQueue.Executar },
                {"Igualdade - Coleções",Igualdade.Executar },
                {"Stack - Coleções",ColecoesStack.Executar },
                {"Dictionary - Coleções",ColecoesDictionary.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}