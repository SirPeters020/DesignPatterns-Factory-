# DesignPatterns-Factory

## Sobre
O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

No exemplo acima o padrão é utilizado para para um sistema de logistica criando objetos do tipo "Aviao", "Trem", "Caminhao", implementandop a interface "ITransporte", utilizando a fabria "TransporteAereio", "TransporteTerreste" e "TransporteFerroviario" implementando a interface "ICorreios"

## Estrutura
- Uma interface, que é comum a todos os objetos (ITransporte) que podem ser produzidos pelo criador(ICorreio) e suas subclasses.
- Objetos Concretos são implementações diferentes da interface do ITransporte (Aviao, Caminhao, Trem).
- A classe ICorreio declara o método fábrica que retorna novos objetos ITransporte. É importante que o tipo de retorno desse método corresponda à interface do produto.
- Classe "Transporte*" sobrescrevem o método fábrica base para retornar um tipo diferente de produto.

### PROS:
- Você evita acoplamentos firmes entre o criador e os produtos concretos.
- Princípio de responsabilidade única. Pode-se mover o código de criação do produto para um único local do programa, facilitando a manutenção do código.
- Princípio aberto/fechado. Pode-se introduzir novos tipos de produtos no programa sem quebrar o código cliente existente.

### CONTRAS:
- O código pode se tornar mais complicado, pois é necessario introduzir muitas subclasses novas para implementar o padrão