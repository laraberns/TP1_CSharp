
# Exercícios de Delegates, Actions, Funcs e Eventos em C#

## 1. Implementação de Delegate Personalizado para Descontos

Imagine que você está desenvolvendo um módulo de regras de negócio para uma aplicação de vendas online. Esse sistema deve aplicar diferentes políticas de desconto conforme o perfil do cliente. Para isso, é necessário encapsular as regras de cálculo de desconto em uma estrutura reutilizável.

**Tarefas:**
- Crie uma aplicação de console em C#.
- Solicite ao usuário que informe o preço original de um produto.
- Crie um delegate chamado `CalculateDiscount` que receba esse valor como `decimal` e retorne o preço com 10% de desconto aplicado.
- Implemente um método compatível com esse delegate.
- Utilize o delegate no fluxo da aplicação para calcular e exibir o valor final ao usuário.

> Este exercício introduz o uso de delegates personalizados para encapsular lógicas de negócio com alta reutilização e manutenção.

---

## 2. Ações Multilíngues com Action<string>

Uma aplicação SaaS voltada ao público internacional precisa exibir mensagens de boas-vindas em diferentes idiomas, conforme a configuração do cliente.

**Tarefas:**
- Crie um programa de console em C#.
- Solicite ao usuário que escolha um idioma (português, inglês ou espanhol).
- Crie uma estrutura com `Action<string>` para exibir a mensagem de boas-vindas no idioma escolhido.
- Implemente ao menos três versões de mensagens encapsuladas nos delegates.

> Este exercício mostra como delegates com `Action` são úteis em interações que envolvem ações sem retorno, como feedback ao usuário.

---

## 3. Cálculo de Área Utilizando Func

Um sistema de engenharia precisa realizar cálculos de área com base em entradas fornecidas pelo operador.

**Tarefas:**
- Crie um programa de console em C#.
- Solicite ao usuário que insira a base e a altura de um retângulo.
- Crie um `Func<double, double, double>` para calcular a área.
- Utilize o delegate para exibir o resultado ao final do processo.

> Esse exercício demonstra o uso prático do `Func` como abstração de cálculos com retorno.

---

## 4. Monitoramento de Temperatura com Evento Personalizado

Sistemas embarcados em ambientes industriais monitoram sensores em tempo real. Uma funcionalidade comum é emitir alertas quando a temperatura ultrapassa o limite seguro.

**Tarefas:**
- Crie uma classe `TemperatureSensor` com um evento `TemperatureExceeded`.
- Solicite entradas do usuário para simular leituras de temperatura.
- Dispare o evento sempre que o valor ultrapassar 100ºC.
- Crie um manipulador que mostre um alerta no console.

> Com este exercício, você aprende a usar eventos para tornar aplicações mais reativas e seguras.

---

## 5. Notificação de Conclusão de Download com Eventos

Ao lidar com tarefas assíncronas, como downloads, sistemas devem informar o usuário sobre a finalização do processo.

**Tarefas:**
- Crie uma classe `DownloadManager`.
- Simule o tempo de download usando `Thread.Sleep`.
- Crie um evento `DownloadCompleted`.
- Dispare o evento ao final do processo e exiba uma mensagem no console.

> Este exercício ensina como eventos são utilizados para notificar o sistema sobre o fim de uma operação.

---

## 6. Sistema de Registro com Multicast Delegate

Uma aplicação corporativa precisa registrar logs simultaneamente em vários destinos: console, arquivo e banco (simulado).

**Tarefas:**
- Crie uma classe `Logger` com três métodos: `LogToConsole`, `LogToFile`, `LogToDatabase`.
- Crie um `Action<string>` multicast delegate.
- Adicione os três métodos ao delegate.
- Ao chamar o delegate com uma mensagem, todas as saídas devem ser executadas.

> Esse exercício reforça como delegates podem ser encadeados para criar comportamentos complexos com baixo acoplamento.

---

## 7. Garantia de Robustez em Invocação de Delegates

Ao usar delegates em tempo de execução, é fundamental garantir que invocações não gerem erros caso não haja métodos associados.

**Tarefas:**
- Reutilize o código do exercício anterior (`Logger`).
- Substitua todas as invocações diretas por chamadas usando `?.Invoke()`.
- Teste o sistema sem nenhum método associado ao delegate e verifique que não ocorrem exceções.

> Esse exercício promove boas práticas para escrita de código mais robusto.
