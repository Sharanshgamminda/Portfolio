#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

void main()
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

    do {
    printf("Bem vindo à exposição sobre os 250 anos de Santos Dumont!\n\n");
    printf("\nAlberto Santos Dumont foi um pioneiro da aviação nascido no Brasil em 1873 e falecido em 1932 na França. \nEle é reconhecido por seus feitos na história da aviação, sendo o primeiro a realizar voos públicos bem-sucedidos em aeronaves mais pesadas do que o ar. \nDumont é famoso por seu 14-Bis, que voou em 1906 e foi o primeiro avião a decolar, voar e pousar perante testemunhas independentes. Além disso, ele também projetou outras invenções que revolucionou o mundo da aviação. \nSantos Dumont foi um visionário da aviação e um grande contribuinte para o desenvolvimento das aeronaves modernas. \n");
    printf("\nInvenções de Santos Dumont:\n");
    printf("- Balão de gás de pequeno porte\n");
    printf("Em 1897, Santos Dumont mudou-se para Paris. E um ano depois, no dia 4 de julho de 1898, ele anunciou a sua nova criação apelidada de 'Brazil' o menor balão criado até então, desafiava os conceitos da época, quando os balões da época mediam de 500 a 2 mil metros cúbicos. O de Dumont tinha apenas 100 metros cúbicos.\n");
    printf("Para a confecção, ele usou a seda japonesa ao invés da chinesa, causando desconfiança em todos. Por conta do seu pequeno porte tinha mais facilidades nessas peripécias, na frança ele ganhou o apelido de 'Petit Santos'.\n");
    printf("\n- Dirigível\n");
    printf("Com a experiência anterior ele decide  dar um passo maior. Como os balões não ofereciam uma dirigibilidade boa, ele decidiu incrementá-los para ter uma maior eficiência de voo. Aí então ele decidiu criar um dos primeiros dirigíveis com motor a gasolina. No dia 13 de novembro de 1889, a bordo da sua terceira versão o N°3, Santos Dumont levantou voo do parque de Aerostação de Vaugirard e contornou a Torre Eiffel. \n");
    printf("\n- Relógio de Pulso \n");
    printf("Santos Dumont, é frequentemente creditado por popularizar o relógio de pulso, não o relógio de bolso. Ele usou o relógio de pulso enquanto pilotava seus aviões para facilitar a leitura do tempo durante os voos. No entanto, a invenção do relógio de bolso não está diretamente associada a Santos-Dumont. Os relógios de bolso já existiam antes de sua época, sendo amplamente utilizados como acessórios de moda e ferramentas de medição do tempo. Santos-Dumont, por sua vez, por volta de 1915 ele contribuiu para a popularização dos relógios de pulso, tornando-os uma escolha prática para atividades como a aviação. \n");
    printf("\n- Hangar \n");
    printf("Embora Santos Dumont  não tenha criado o conceito de hangar, ele projetou e construiu o primeiro hangar de aviação do mundo. Em 1901, Santos-Dumont projetou e construiu o primeiro hangar de aviação na história. Este hangar foi construído no Campo de Bagatelle, em Paris, França. O hangar era uma estrutura de madeira e lona, projetada para abrigar seu famoso dirigível Nº 6, também conhecido como '14-bis'. O hangar permitiu a Santos-Dumont realizar experimentos e testes de suas aeronaves com mais privacidade e proteção contra as condições climáticas. \n");
    printf("\n- 14-Bis \n");
    printf("Enquanto a maioria do mundo credita os irmãos Wright dos Estados Unidos, o brasileiro Santos Dumont demonstrou publicamente o voo com uma aeronave mais pesada do que o ar em 1906 com o 14-Bis. Os defensores dos Wright argumentam que eles o fizeram três anos antes, mas sem exposição pública. Santos Dumont, no entanto, ressalta que sua aeronave era superior e que os Wright disseram ter copiado seu design. A disputa histórica persiste, mas as exibições subsequentes dos Wright acabaram convencendo o mundo, incluindo Paris, onde Santos Dumont se estabeleceu. \n");
    printf("\n------------------------------------------------------\n");
    printf("Agora vamos testar o que você aprendeu! \n");
    do
    {
        continua = 1;
        printf("A.  \n");
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
        printf("B.  \n");
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
        printf("C.  \n");
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
        printf("Gostaria de iniciar a exposição de Santos Dumont? \n1 - Sim \n2 - Não \n");
        scanf("%d", &programaRoda);
        system("cls");
    }
    while (continua == 1);
    }
    while (programaRoda == 1);
}
