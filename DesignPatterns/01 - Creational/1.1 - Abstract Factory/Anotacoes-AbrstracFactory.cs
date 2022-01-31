
/*
 Abstract Factory

Uma das suas maiores vantagens é que emcapsulamos toda regra de negocio responsavel por cada tamanho de guincho 
em sua classe expecifica não sendo necessario utilizar varios IFS.
Nos metodos onde se faz necessario a utilização da regra não passamos as classes expecificas mais sim a abstração
"Guincho".
Neste exeomplo podemos ver a aplicação do Principio de Liskovy na qual é possivel observar como se deve utilizar 
a herança.

Este patter é recomendado sempre quando houver variacoes, podemos observar que para cada tipo de porte 
devolvemos um tipo de objeto de veiculo ("pequeno","medio","grande").
Porem lá no metodo de Socorrer da classe Guincho ele não conhece estas classes para ele somente existe o veiculo
ou seja a abstração.

A Classe "AutoSocorro" é o CLient, ou seja quem está consumindo o Pattern.
Como parametro do construtor ele recebe apenas o AbstractFactory ou seja a fabrica da fabrica, caso aparecer uma nova implementação
para um novo tipó de veiculo, não se faz mais necessario alterar esta classe

 */