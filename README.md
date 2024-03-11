# Desafio Target

1) Observe o trecho de código abaixo:

```
int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);

```

Ao final do processamento, qual será o valor da variável SOMA? 

`Resposta da questão 1 = 91`

> A lógica da resposta da questão 1 se encontra no código do projeto.

<br>

 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

  > A lógica da resposta da questão 2 se encontra no código do projeto.

<br>

3) Descubra a lógica e complete o próximo elemento:

a) 1, 3, 5, 7, ___

b) 2, 4, 8, 16, 32, 64, ____

c) 0, 1, 4, 9, 16, 25, 36, ____

d) 4, 16, 36, 64, ____

e) 1, 1, 2, 3, 5, 8, ____

f) 2,10, 12, 16, 17, 18, 19, ____

```
Resposta da questão 3:

a) Nessa sequência, os números aumentam de 2 em 2. Então, o próximo será 7 + 2 = 9.

Resposta: 9

b) Parece que cada número está dobrando em relação ao anterior. Assim, o próximo será 64 * 2 = 128.

Resposta: 128

c) Essa sequência é formada pelos quadrados dos números naturais, começando de 0. O próximo será 7^2 = 49.

Resposta: 49

d) Aqui, estamos vendo os quadrados dos números pares a partir de 2. O próximo será 10^2 = 100.

Resposta: 100

e) Esta é a sequência de Fibonacci, onde cada número é a soma dos dois anteriores. O próximo será 8 + 5 = 13.

Resposta: 13

f) Essa sequência parece ter aumentos irregulares. O próximo será 19 + 1 = 20.

Resposta: 20

```

<br>

4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

Resposta da questão 4: 

```
Então, primeiro eu ligo um dos interruptores e espero um pouco. Depois, desligo esse primeiro interruptor e ligo o segundo. Aí sim, eu vou até a sala das lâmpadas.
Se uma lâmpada desligada estiver meio quente, essa é a do primeiro interruptor. Se uma lâmpada estiver acesa, é do segundo interruptor.
Agora, a que estiver apagada e completamente fria, essa é do terceiro interruptor.

```

<br>

5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;


> A lógica da resposta da questão 5 se encontra no código do projeto.
