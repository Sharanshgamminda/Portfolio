#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

void main()
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");

    int sessao;
    int continua = 1;
    int tipoIngresso = 1;
    int ingresso = 50;
    int quantiaIngressos = 200;
    int valorTotalIngresso = 0;
    int contagemIngressos [4][3] =
    {
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
    };


    printf("Bem vindo ao nosso museu!\n");
    while (continua == 1)
    {
        int controleCompraIngresso = 1;
        while (controleCompraIngresso == 1)
        {
            printf("Qual seu tipo de ingresso?\n1 - Inteira \n2 - Meia entrada \n3 - Isenção de ingresso\n");
            scanf("%d", &tipoIngresso);
            ingresso = 50;

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
        printf("Qual sessão você gostaria de ver? \n1 - Santos Dummont \n2 - Olimpíadas 2024 \n3 - Semana da Arte Moderna \n4 - Titanic\n");
        scanf("%d", &sessao);

        switch (sessao)
        {
        case 1:
        {
            printf("250 anos de Santos Dumont\n");
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
            printf("Olimpíadas 2024\n");
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
            printf("100 anos da Semana de Arte Moderna\n");
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
            printf("Titanic\n");
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
            printf("Gostaria de ver outra exposição?\n1 - sim\n2 - não\n");
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
    printf("Obrigado pela preferência! Seu total deu: %d reais, efetue o pagamento no guichê!\n", valorTotalIngresso);
    int i, j;
    for (i = 0; i < 4; i++)
    {
        for (j = 0; j < 3; j++)
            printf("%d ", contagemIngressos[i][j]);
        printf("\n");
    }
    printf("%d", quantiaIngressos);

}
