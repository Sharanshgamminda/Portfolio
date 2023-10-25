#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(void)
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");
    int respostas[5][4] = {
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
    };
    int continua = 1, programaRoda = 1, resposta;

    while(programaRoda == 1)
    {
        printf("Bem vindo à exposição sobre os Jogos Olímpicos de Paris 2024! \n");
        printf("'O plano dos Jogos Paris 2024 não foi elaborado apenas para garantir uma ótima experiência ao atleta, mas também para garantir um legado duradouro para a comunidade. O Centro Aquático será usado como um novo centro de treinamento de elite e como uma instalação de natação recreativa, extremamente necessária em uma área de Paris onde 50% das crianças não sabem nadar. Além das instalações de competição, 100 milhões de euros serão investidos em instalações esportivas locais, muitas das quais serão usadas como instalações de treinamento durante os Jogos, garantindo que os benefícios de sediar os Jogos sejam compartilhados com toda a região sede. Um foco especial será colocado na melhoria dessas instalações para torná-las totalmente acessíveis. Finalmente, um impacto fundamental e inestimável de sediar os Jogos de 2024 em Paris será a mudança de mentalidade em relação às pessoas com deficiência, não apenas dentro da comunidade esportiva, mas em toda a sociedade francesa.' \n");
        printf("\n- Onde serão realizadas os Jogos Olímpicos de 2024? \n");
        printf("Os Jogos Olímpicos de Verão de 2024 serão realizados em Paris, França. Haverá um total de 35 instalações, com quatorze locais hospedando 24 esportes olímpicos localizados a 10 km da Vila Olímpica. Os Jogos acontecerão em vários locais ao redor de Paris, como les Yvelines, Hauts-de-Seine, Seine-et-Marne e Seine-Saint-Denis. No entanto, os Jogos de Paris 2024 vão se estender a muitas outras áreas da França, com o torneio de futebol sendo disputado em outras seis cidades (Bordeaux, Nantes, Lyon, Saint-Etienne, Nice e Marselha), a vela em Marselha e o surf em o local de Teahupo'o no Taiti. \n");
        printf("\n- Quando são os Jogos Olímpicos de Paris 2024? \n");
        printf("Os Jogos Olímpicos de Verão de 2024 serão realizados de sexta-feira, 26 de julho de 2024, a domingo, 11 de agosto de 2024. No entanto, as competições de futebol e rugby começarão em 24 de julho e o torneio de handebol no dia 25. Em pouco mais de três semanas, serão realizados 329 eventos em 32 esportes, com um total de 206 CONs competindo, além da Equipe Olímpica de Refugiados. \n");
        printf("\n- Que novos esportes estarão nos Jogos Olímpicos de Paris 2024? \n");
        printf("Breaking é o único esporte que faz sua estreia em Paris 2024. Nos Jogos de Paris 2024, a competição de break será composta por dois eventos – um para homens e outro para mulheres – onde 16 B-Boys e 16 B-Girls se enfrentarão em batalhas individuais. Os atletas vão usar uma combinação de movimentos e improvisar ao ritmo das faixas do DJ. O breaking fez sua estreia nos Jogos Olímpicos da Juventude em Buenos Aires em 2018. \n");
        printf("\n------------------------------------------------------\n");
        printf("Agora vamos testar o que você aprendeu! \n");
        do
        {
            continua = 1;
            printf("A. Em que cidade as Olimpíadas de 2024 serão realizadas? \n 1) Paris \n 2) Los Angeles \n 3) Tóquio \n 4) Rio de Janeiro \n");
            scanf("%d", &resposta);
            switch(resposta){
                case 1:{
                    respostas[0][0]++;
                    continua = 0;
                    break;
                }
                case 2:{
                    respostas[0][1]++;
                    continua = 0;
                    break;
                }
                case 3:{
                    respostas[0][2]++;
                    continua = 0;
                    break;
                }
                case 4:{
                    respostas[0][3]++;
                    continua = 0;
                    break;
                }
                default :{
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
            printf("B. Qual é o esporte considerado o carro-chefe das Olimpíadas de 2024? \n 1) Atletismo \n 2) Natação \n 3) Futebol \n 4) Ginástica artística \n");
            scanf("%d", &resposta);
            switch(resposta){
                case 1:{
                    respostas[1][0]++;
                    continua = 0;
                    break;
                }
                case 2:{
                    respostas[1][1]++;
                    continua = 0;
                    break;
                }
                case 3:{
                    respostas[1][2]++;
                    continua = 0;
                    break;
                }
                case 4:{
                    respostas[1][3]++;
                    continua = 0;
                    break;
                }
                default :{
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
            printf("C. Qual é o mascote oficial das Olimpíadas de 2024? \n 1) Leão \n 2) Coelho \n 3) Girafa \n 4) Urso \n");
            scanf("%d", &resposta);
            switch(resposta){
                case 1:{
                    respostas[2][0]++;
                    continua = 0;
                    break;
                }
                case 2:{
                    respostas[2][1]++;
                    continua = 0;
                    break;
                }
                case 3:{
                    respostas[2][2]++;
                    continua = 0;
                    break;
                }
                case 4:{
                    respostas[2][3]++;
                    continua = 0;
                    break;
                }
                default :{
                    printf("Opção inválida! \n");
                    continua = 1;
                    break;
                }
            }
        }
        while (continua == 1);
        do
        {
            printf("D. Em qual ano ocorreram as últimas Olimpíadas de Verão antes de 2024? \n 1) 2016 \n 2) 2020 \n 3) 2022 \n 4) 2018 \n");
            scanf("%d", &resposta);
            switch(resposta){
                case 1:{
                    respostas[3][0]++;
                    continua = 0;
                    break;
                }
                case 2:{
                    respostas[3][1]++;
                    continua = 0;
                    break;
                }
                case 3:{
                    respostas[3][2]++;
                    continua = 0;
                    break;
                }
                case 4:{
                    respostas[3][3]++;
                    continua = 0;
                    break;
                }
                default :{
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
            printf("E. Quantos países participarão das Olimpíadas de 2024? \n 1) 150 \n 2) 200 \n 3) 250 \n 4) 300 \n");
            scanf("%d", &resposta);
            switch(resposta){
                case 1:{
                    respostas[4][0]++;
                    continua = 0;
                    break;
                }
                case 2:{
                    respostas[4][1]++;
                    continua = 0;
                    break;
                }
                case 3:{
                    respostas[4][2]++;
                    continua = 0;
                    break;
                }
                case 4:{
                    respostas[4][3]++;
                    continua = 0;
                    break;
                }
                default :{
                    printf("Opção inválida! \n");
                    continua = 1;
                    break;
                }
            }
        }
        while (continua == 1);
        printf("Gostaria de iniciar a exposição dos jogos olímpicos de 2024? \n1 - Sim \n2 - Não \n");
        scanf("%d", &programaRoda);
        system("cls");
    }
    printf("Programa concluído, exportando dados...");

    int i;

    FILE *fp = fopen("Respostas_Olimpiadas.csv", "w");

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

    printf("Dados exportados para Respostas_Olimpiadas.csv com sucesso.\n");

    return 0;
}
