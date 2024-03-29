#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(void)
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");
    int continua = 1, programaRoda = 1, resposta;
    int respostas[4][4] =
    {
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
    };

    while (programaRoda == 1)
    {
        printf("Bem vindo à exposição sobre os 100 anos da Semana de Arte Moderna!\n");
        printf("\nA Semana de Arte Moderna ocorreu entre os dias de 13 a 17 de Fevereiro de 1922 e foi um evento artístico que reuniu várias formas de expressão, como dança, pintura, escultura, poesia, literatura e música. \n");
        printf("O evento foi marcado por conter várias obras que traziam uma forma muito diferente do costume da época, ao conter fortes influências externas europeias, como o expressionismo, cubismo, dadaísmo e surrealismo, em contraste ao tradicionalismo, utilizando por exemplo uma linguagem mais coloquial e até vulgar. Com isso o evento trouxe um grande choque ao público e dividiu opiniões. \n");
        printf("\n- O movimento reuniu obras de artistas como:\n");
        printf("Mario de Andrade, Oswald de Andrade, Di Cavalcanti, Menotti del Picchia, Manuel Bandeira, Villa Lobos, Anita Malfatti, entre outros.. \n");
        printf("\nO famoso quadro Abaporu, de Tarsila do Amaral, foi pintado em 1928 e dado de presente para o escritor Oswald de Andrade, que em conjunto com o poeta Raul Bopp, lhe atribuiu esse nome. Abaporu vem do tupi e significa o homem que come gente. \n");
        printf("\nO quadro Operários, de Tarsila do Amaral, foi pintado em 1933, demonstra simbolicamente a situação dos trabalhadores no período em questão, época da industrialização no Brasil, com empregamento em massa de imigrantes de diversos países procurando oportunidade no Brasil, apesar disso, todos os 51 operários retradados demonstram uma feição de cansaço ou desesperança. \n");
        printf("\n------------------------------------------------------\n");
        printf("Agora vamos testar o que você aprendeu! \n");
        do
        {
            continua = 1;
            printf("A. Em que cidade ocorreu a Semana de Arte Moderna? \n 1) São Paulo \n 2) Rio de Janeiro \n 3) Salvador \n 4) Brasília \n");
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
            printf("B. Em que ano deu-se lugar ao evento? \n 1) 1816 \n 2) 1891 \n 3) 1922 \n 4) 1964 \n");
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
            printf("C. Em Tupi, o que significa Abaporu? \n 1) O homem que vê gente \n 2) O homem que ensina gente \n 3) O homem que come gente \n 4) O homem que mata gente \n");
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
        }
        while (continua == 1);
        do
        {
            printf("D. Quem pintou o quadro 'Operários'? \n 1) Pablo Picasso \n 2) Mario de Andrade \n 3) Anita Malfatti \n 4) Tarsila do Amaral \n");
            scanf("%d", &resposta);
            switch(resposta)
            {
            case 1:
            {
                respostas[3][0]++;
                continua = 0;
                break;
            }
            case 2:
            {
                respostas[3][1]++;
                continua = 0;
                break;
            }
            case 3:
            {
                respostas[3][2]++;
                continua = 0;
                break;
            }
            case 4:
            {
                respostas[3][3]++;
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
        printf("Gostaria de reinicializar a exposição da semana de arte moderna? \n1 - Sim \n2 - Não \n");
        scanf("%d", &programaRoda);
        system("cls");
    }

    printf("Programa concluído, exportando dados..");

    int i;

    FILE *fp = fopen("Respostas_Semana_Arte.csv", "w");

    if (fp == NULL)
    {
        printf("Não foi possível abrir o arquivo.\n");
        return 1;
    }

    fprintf(fp, "Respostas:, 1), 2), 3), 4)");

    fprintf(fp, "\nA,%d, %d, %d, %d\n", respostas[0][0], respostas[0][1], respostas[0][2], respostas[0][3]);
    fprintf(fp, "B,%d, %d, %d, %d\n", respostas[1][0], respostas[1][1], respostas[1][2], respostas[1][3]);
    fprintf(fp, "C,%d, %d, %d, %d\n", respostas[2][0], respostas[2][1], respostas[2][2], respostas[2][3]);
    fprintf(fp, "D,%d, %d, %d, %d\n", respostas[3][0], respostas[3][1], respostas[3][2], respostas[3][3]);

    fclose(fp);

    printf("Dados exportados para Respostas_Semana_Arte.csv com sucesso.\n");

    return 0;
}
