#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(void)
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");

    int sessao;
    int continua = 1, programaRoda = 1;
    int tipoIngresso = 1;
    int ingresso = 40;
    int quantiaIngressos = 200;
    int valorTotalIngresso = 0;
    int i, j;
    int contagemIngressos [4][3] =
    {
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
    };


    printf("Bem vindo ao nosso museu!\n");
    do
    {
        programaRoda = 1;
        continua = 1;
        valorTotalIngresso = 0;
        while (continua == 1)
        {
            if (quantiaIngressos <=0)
            {
                printf("\n-------------------\n!!! Opa, nossos ingressos esgotaram por hoje! Volte novamente amanhã !!!\n-------------------\n");
                continua = 0;
            }
            else
            {
                int controleCompraIngresso = 1;
                while (controleCompraIngresso == 1)
                {
                    printf("\nQual seu tipo de ingresso?\n1 - Inteira \n2 - Meia entrada \n3 - Isenção de ingresso\n");
                    scanf("%d", &tipoIngresso);
                    ingresso = 40;

                    switch(tipoIngresso)
                    {
                    case 1:
                    {
                        printf("Seu ingresso sai: %d reais\n", ingresso);
                        controleCompraIngresso = 0;
                        break;
                    }
                    case 2:
                    {
                        ingresso = ingresso/2;
                        printf("Seu ingresso sai: %d reais\n", ingresso);
                        controleCompraIngresso = 0;
                        break;
                    }
                    case 3:
                    {
                        ingresso = 0;
                        printf("Seu ingresso sai isento de valor!\n");
                        controleCompraIngresso = 0;
                        break;
                    }
                    default:
                    {
                        printf("Opção inválida!\n");
                        controleCompraIngresso = 1;
                        break;
                    }
                    }

                }
                quantiaIngressos -= 1;
                printf("\nQual sessão você gostaria de ver? \n1 - Santos Dumont \nSantos Dumont foi um mineiro, conhecido mundialmente por ser o inventor do avião \n2 - Olimpíadas 2024 \nAs Olimpíadas que irão ocorrer na França em 2024 \n3 - Semana da Arte Moderna \nA Semana de Arte Moderna foi um evento cultural e artístico inovador no Brasil\n4 - Titanic \nO Titanic foi uma maravilha da invenção para barcos da época de sua criação \n");
                scanf("%d", &sessao);

                switch (sessao)
                {
                case 1:
                {
                    printf("Você escolheu a exposição: 150 anos de Santos Dumont\n");
                    valorTotalIngresso = valorTotalIngresso + ingresso;
                    if (tipoIngresso == 1)
                    {
                        contagemIngressos [0][0]++;
                    }
                    if (tipoIngresso == 2)
                    {
                        contagemIngressos [0][1]++;
                    }
                    if (tipoIngresso == 3)
                    {
                        contagemIngressos[0][2]++;
                    }
                    printf("Seu total até o momento deu %d reais\n", valorTotalIngresso);
                    break;
                }
                case 2:
                {
                    printf("Você escolheu a exposição: Olimpíadas 2024\n");
                    valorTotalIngresso = valorTotalIngresso + ingresso;
                    if (tipoIngresso == 1)
                    {
                        contagemIngressos [1][0]++;
                    }
                    if (tipoIngresso == 2)
                    {
                        contagemIngressos [1][1]++;
                    }
                    if (tipoIngresso == 3)
                    {
                        contagemIngressos [1][2]++;
                    }
                    printf("Seu total até o momento deu %d reais\n", valorTotalIngresso);
                    break;
                }
                case 3:
                {
                    printf("Você escolheu a exposição: 100 anos da Semana de Arte Moderna\n");
                    valorTotalIngresso = valorTotalIngresso + ingresso;
                    if (tipoIngresso == 1)
                    {
                        contagemIngressos [2][0]++;
                    }
                    if (tipoIngresso == 2)
                    {
                        contagemIngressos [2][1]++;
                    }
                    if (tipoIngresso == 3)
                    {
                        contagemIngressos [2][2]++;
                    }
                    printf("Seu total até o momento deu %d reais\n", valorTotalIngresso);
                    break;
                }
                case 4:
                {
                    printf("Você escolheu a exposição: Titanic\n");
                    valorTotalIngresso = valorTotalIngresso + ingresso;
                    if (tipoIngresso == 1)
                    {
                        contagemIngressos [3][0]++;
                    }
                    if (tipoIngresso == 2)
                    {
                        contagemIngressos [3][1]++;
                    }
                    if (tipoIngresso == 3)
                    {
                        contagemIngressos [3][2]++;
                    }
                    printf("Seu total até o momento deu %d reais\n", valorTotalIngresso);
                    break;
                }
                default :
                {
                    printf("Opção inválida!\n");
                }
                }
                int controleResposta = 0;
                while(controleResposta == 0)
                {
                    printf("\nGostaria de ver outra exposição?\n1 - sim\n2 - não\n");
                    scanf("%d", &controleResposta);
                    if (controleResposta == 1)
                    {
                        continua = controleResposta;
                    }
                    else if (controleResposta == 2)
                    {
                        continua = controleResposta;
                    }
                    else
                    {
                        printf("Opção inválida! Tente novamente!\n");
                        controleResposta = 0;
                    }
                }
            }

        }
        printf("\nObrigado pela preferência! Seu total deu: %d reais, efetue o pagamento no guichê!\n", valorTotalIngresso);
        printf("\nGostaria de reiniciar a venda de ingressos? \n1 - Sim \n2 - Não \n");
        scanf("%d", &programaRoda);
        system("cls");
    }
    while (programaRoda == 1);

    const char *controle[] = {"Santos Dumont", "Olimpíadas 2024", "Semana de Arte Moderna", "Titanic"};
    int sessoes = 4, modalidade = 3;


    FILE *fp = fopen("controle.csv", "w");

    if (fp == NULL)
    {
        printf("Não foi possível abrir o arquivo.\n");
        return 1;
    }

    fprintf(fp, "Controle,");

    for (i = 0; i < sessoes; i++)
    {
        fprintf(fp, "%s,", controle[i]);
    }
    fprintf(fp, "\nInteira, %d, %d, %d, %d\n", contagemIngressos [0][0], contagemIngressos [1][0], contagemIngressos [2][0], contagemIngressos [3][0]);
    fprintf(fp, "Meia, %d, %d, %d, %d\n", contagemIngressos [0][1], contagemIngressos [1][1], contagemIngressos [2][1], contagemIngressos [3][1]);
    fprintf(fp, "Isenta, %d, %d, %d, %d\n", contagemIngressos [0][2], contagemIngressos [1][2], contagemIngressos [2][2], contagemIngressos [3][2]);
    fprintf(fp, "Ingressos que restaram de hoje:, %d\n", quantiaIngressos);

    fclose(fp);

    printf("Ingressos exportados para controle.csv com sucesso.\n");

    return 0;

}
