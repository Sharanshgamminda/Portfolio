#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(void)
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");
    int respostas[3][4] =
    {
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
    };
    int continua = 1, programaRoda = 1, resposta;
    do
    {
        printf("Bem vindo à exposição sobre o Titanic! \n");
        printf("\nRMS Titanic (mais conhecido como Titanic) foi um navio construído no século XX na Irlanda do Norte. No tempo em que foi construído, era um símbolo de grandeza por ser o maior de todos os navios de passageiros do mundo, e, ao mesmo tempo, superluxuoso. A sigla do Titanic RMS significa Royal Mail Steamer (Navio do Correio Real), pois o navio também era usado como transporte das correspondências do Correio Real Britânico.\n");
        printf("\nO Titanic teve o custo de 7,5 milhões de dólares na época (234 milhões hoje, corrigido de acordo com a inflação). Além do gasto por recursos pelo seu tamanho colossal, o navio possuía diversas instalações como restaurantes, bibliotecas, elevadores, barbearias e entre outros. Os aspectos de luxo eram bem presentes pelo navio, seu interior sendo rico em decorações e ornamentos.\n");
        printf("\nHavia mais de 2200 pessoas em sua viagem inaugural, saindo de Southampton, na Inglaterra, em 10 de abril de 1912, rumo a cidade de Nova Iorque. Sua viagem, porém, foi interrompida quatro dias depois, após uma colisão com o iceberg que afundou o navio, causando o incidente que matou 1500 pessoas, considerado um dos piores acidentes da história da navegação marítima.\n");
        printf("\nApós o naufrágio, diversas melhorias na segurança das embarcações foram implementadas para que essa tragédia não voltasse a acontecer. Radares de detectar ameaças como icebergs e o aumento de salva-vidas são algumas dessas melhorias.\n");
        printf("\n------------------------------------------------------\n");
        printf("Agora vamos testar o que você aprendeu! \n");
        do
        {
            continua = 1;
            printf("A. Em sua viagem inaugural (antes de ter colidido com o iceberg que o afundou) o Titanic partiu de Southampton, na Inglaterra, em 10 de abril de 1912, rumo a cidade de: \n 1) Barcelona, Espanha \n 2) Sydney, Austrália \n 3) Nova Iorque, EUA \n 4) Rio de Janeiro, Brasil \n");
            scanf("%d", &resposta);
            switch(resposta)
            {
            case 1:
            {
                respostas[0][0]++;
                continua = 0;
                break;
            }
            case 2:
            {
                respostas[0][1]++;
                continua = 0;
                break;
            }
            case 3:
            {
                respostas[0][2]++;
                continua = 0;
                break;
            }
            case 4:
            {
                respostas[0][3]++;
                continua = 0;
                break;
            }
            default :
            {
                printf("Opção inválida! \n");
                continua = 1;
                break;
            }
            }
        }
        while (continua == 1);
        do
        {
            continua = 1;
            printf("B. Qual o significado da sigla RMS do nome RMS Titanic? \n 1) Royal Mail Ship \n 2) Royal Majesty Ship \n 3) Royal Maritime Service \n 4) Royal Mail Steamer \n");
            scanf("%d", &resposta);
            switch(resposta)
            {
            case 1:
            {
                respostas[1][0]++;
                continua = 0;
                break;
            }
            case 2:
            {
                respostas[1][1]++;
                continua = 0;
                break;
            }
            case 3:
            {
                respostas[1][2]++;
                continua = 0;
                break;
            }
            case 4:
            {
                respostas[1][3]++;
                continua = 0;
                break;
            }
            default :
            {
                printf("Opção inválida! \n");
                continua = 1;
                break;
            }
            }
        }
        while (continua == 1);
        do
        {
            continua = 1;
            printf("C. Onde o Titanic afundou após colidir com o Iceberg? \n 1) Oceano Atlântico \n 2) Oceano Pacífico \n 3) oceano Índico \n 4) Oceano Ártico \n");
            scanf("%d", &resposta);
            switch(resposta)
            {
            case 1:
            {
                respostas[2][0]++;
                continua = 0;
                break;
            }
            case 2:
            {
                respostas[2][1]++;
                continua = 0;
                break;
            }
            case 3:
            {
                respostas[2][2]++;
                continua = 0;
                break;
            }
            case 4:
            {
                respostas[2][3]++;
                continua = 0;
                break;
            }
            default :
            {
                printf("Opção inválida! \n");
                continua = 1;
                break;
            }
            }
            printf("Gostaria de iniciar a exposição dos jogos olímpicos de 2024? \n1 - Sim \n2 - Não \n");
            scanf("%d", &programaRoda);
            system("cls");
        }
        while (continua == 1);
    }
    while (programaRoda == 1);
    printf("Programa concluído, exportando dados...");

    int i;

    FILE *fp = fopen("Respostas_Titanic.csv", "w");

    if (fp == NULL)
    {
        printf("Não foi possível abrir o arquivo.\n");
        return 1;
    }

    fprintf(fp, "Respostas:, 1), 2), 3), 4)");

    fprintf(fp, "\nA,%d, %d, %d, %d\n", respostas[0][0], respostas[0][1], respostas[0][2], respostas[0][3]);
    fprintf(fp, "B,%d, %d, %d, %d\n", respostas[1][0], respostas[1][1], respostas[1][2], respostas[1][3]);
    fprintf(fp, "C,%d, %d, %d, %d\n", respostas[2][0], respostas[2][1], respostas[2][2], respostas[2][3]);


    fclose(fp);

    printf("Dados exportados para Respostas_Titanic.csv com sucesso.\n");

    return 0;
}
