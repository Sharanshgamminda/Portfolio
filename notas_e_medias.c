#include <stdio.h>
#include <locale.h>

int main (void)
{
    setlocale(LC_ALL, "Portuguese");

    float notasDisciplina [100][3], mediaAlunoN [100], soma, somaTotal = 0, media;
    int i, j, n, alunosPassados = 0, alunoN = 0;

    printf("Digite a quantidade de alunos: ");
    scanf("%d", &n);

    printf("Você irá cadastrar %d alunos \n", n);

    for(i=0; i<n; i++)
    {
        soma = 0;
        for(j=0; j<3; j++)
        {
            // aqui iremos gravar nossa matriz
            printf("Digite a nota do aluno %d para a disciplina %d: ", i+1, j+1);
            scanf("%f", &notasDisciplina[i][j]);

            soma += notasDisciplina[i][j];
            printf("A soma até agora deu %f \n", soma);

            fflush(stdin);
        }
        media = soma/3;
        printf("A média do aluno %d deu %f \n\n",i+1, media);
        mediaAlunoN[i] = media;
        if(media >= 7)
        {
            alunosPassados += 1;
        }
    }
    printf("Exibindo as notas gravadas \n");
    printf("------------------------------\n");
    for(i=0; i<n; i++)
    {
        for(j=0; j<3; j++)
        {
            printf("%f ", notasDisciplina[i][j]);
        }
        printf("\n");
    }
    printf("\nExibindo dados coletados \n");
    printf("------------------------------\n");
    soma = 0;
    for(i=0; i<n; i++)
    {
        for(j=0; j<3; j++)
        {
            soma += notasDisciplina[i][j];
        }
    }
    for(j=0; j<3; j++)
    {
        media = 0;
        soma = 0;
        for(i=0; i<n; i++)
        {
            soma += notasDisciplina[i][j];
        }
        somaTotal += soma;
        media = soma/n;
        printf("A média da disciplina %d deu %f \n", j+1, media);
    }
    printf("A soma total deu %f \n", somaTotal);
    media = somaTotal/(n*3);
    printf("A média global é %f \n", media);
    printf("A quantidade de alunos que foram aprovados é %d \n", alunosPassados);

    printf("\nEscolha um aluno: ");
    scanf("%d", &alunoN);
    if(alunoN <= n)
    {
        printf("A média do aluno %d é %f", alunoN, mediaAlunoN[(alunoN-1)]);
    } else {
        printf("Escolha inválida");
    }
}
