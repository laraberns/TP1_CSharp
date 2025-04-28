
# Exerc�cios de Delegates, Actions, Funcs e Eventos em C#

## 1. Implementa��o de Delegate Personalizado para Descontos

Imagine que voc� est� desenvolvendo um m�dulo de regras de neg�cio para uma aplica��o de vendas online. Esse sistema deve aplicar diferentes pol�ticas de desconto conforme o perfil do cliente. Para isso, � necess�rio encapsular as regras de c�lculo de desconto em uma estrutura reutiliz�vel.

**Tarefas:**
- Crie uma aplica��o de console em C#.
- Solicite ao usu�rio que informe o pre�o original de um produto.
- Crie um delegate chamado `CalculateDiscount` que receba esse valor como `decimal` e retorne o pre�o com 10% de desconto aplicado.
- Implemente um m�todo compat�vel com esse delegate.
- Utilize o delegate no fluxo da aplica��o para calcular e exibir o valor final ao usu�rio.

> Este exerc�cio introduz o uso de delegates personalizados para encapsular l�gicas de neg�cio com alta reutiliza��o e manuten��o.

---

## 2. A��es Multil�ngues com Action<string>

Uma aplica��o SaaS voltada ao p�blico internacional precisa exibir mensagens de boas-vindas em diferentes idiomas, conforme a configura��o do cliente.

**Tarefas:**
- Crie um programa de console em C#.
- Solicite ao usu�rio que escolha um idioma (portugu�s, ingl�s ou espanhol).
- Crie uma estrutura com `Action<string>` para exibir a mensagem de boas-vindas no idioma escolhido.
- Implemente ao menos tr�s vers�es de mensagens encapsuladas nos delegates.

> Este exerc�cio mostra como delegates com `Action` s�o �teis em intera��es que envolvem a��es sem retorno, como feedback ao usu�rio.

---

## 3. C�lculo de �rea Utilizando Func

Um sistema de engenharia precisa realizar c�lculos de �rea com base em entradas fornecidas pelo operador.

**Tarefas:**
- Crie um programa de console em C#.
- Solicite ao usu�rio que insira a base e a altura de um ret�ngulo.
- Crie um `Func<double, double, double>` para calcular a �rea.
- Utilize o delegate para exibir o resultado ao final do processo.

> Esse exerc�cio demonstra o uso pr�tico do `Func` como abstra��o de c�lculos com retorno.

---

## 4. Monitoramento de Temperatura com Evento Personalizado

Sistemas embarcados em ambientes industriais monitoram sensores em tempo real. Uma funcionalidade comum � emitir alertas quando a temperatura ultrapassa o limite seguro.

**Tarefas:**
- Crie uma classe `TemperatureSensor` com um evento `TemperatureExceeded`.
- Solicite entradas do usu�rio para simular leituras de temperatura.
- Dispare o evento sempre que o valor ultrapassar 100�C.
- Crie um manipulador que mostre um alerta no console.

> Com este exerc�cio, voc� aprende a usar eventos para tornar aplica��es mais reativas e seguras.

---

## 5. Notifica��o de Conclus�o de Download com Eventos

Ao lidar com tarefas ass�ncronas, como downloads, sistemas devem informar o usu�rio sobre a finaliza��o do processo.

**Tarefas:**
- Crie uma classe `DownloadManager`.
- Simule o tempo de download usando `Thread.Sleep`.
- Crie um evento `DownloadCompleted`.
- Dispare o evento ao final do processo e exiba uma mensagem no console.

> Este exerc�cio ensina como eventos s�o utilizados para notificar o sistema sobre o fim de uma opera��o.

---

## 6. Sistema de Registro com Multicast Delegate

Uma aplica��o corporativa precisa registrar logs simultaneamente em v�rios destinos: console, arquivo e banco (simulado).

**Tarefas:**
- Crie uma classe `Logger` com tr�s m�todos: `LogToConsole`, `LogToFile`, `LogToDatabase`.
- Crie um `Action<string>` multicast delegate.
- Adicione os tr�s m�todos ao delegate.
- Ao chamar o delegate com uma mensagem, todas as sa�das devem ser executadas.

> Esse exerc�cio refor�a como delegates podem ser encadeados para criar comportamentos complexos com baixo acoplamento.

---

## 7. Garantia de Robustez em Invoca��o de Delegates

Ao usar delegates em tempo de execu��o, � fundamental garantir que invoca��es n�o gerem erros caso n�o haja m�todos associados.

**Tarefas:**
- Reutilize o c�digo do exerc�cio anterior (`Logger`).
- Substitua todas as invoca��es diretas por chamadas usando `?.Invoke()`.
- Teste o sistema sem nenhum m�todo associado ao delegate e verifique que n�o ocorrem exce��es.

> Esse exerc�cio promove boas pr�ticas para escrita de c�digo mais robusto.
