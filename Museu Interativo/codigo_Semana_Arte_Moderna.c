#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

void main()
{
    system("chcp 65001");
    system("cls");
    setlocale(LC_ALL, "Portuguese_Brasil");

    printf("Bem vindo à exposição sobre os 100 anos da Semana de Arte Moderna!\n");
    printf("A Semana de Arte Moderna ocorreu entre os dias de 13 a 17 de Fevereiro de 1922 e foi um evento artístico que reuniu várias formas de expressão, como dança, pintura, escultura, poesia, literatura e música. \nO evento foi marcado por conter várias obras que traziam uma forma muito diferente do costume da época, ao conter fortes influências externas europeias, como o expressionismo, cubismo, dadaísmo e surrealismo, em contraste ao tradicionalismo, utilizando por exemplo uma linguagem mais coloquial e até vulgar. Com isso o evento trouxe um grande choque ao público e dividiu opiniões. \n");

}
