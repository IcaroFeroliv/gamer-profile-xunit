# GamerProfile - Testes Unitários com xUnit 🎮

Este repositório contém a solução `GamerProfile`, desenvolvida como parte da disciplina de Garantia da Qualidade de Software / Gestão e Qualidade de Software. 

## 🎯 Propósito do Sistema
O sistema é uma aplicação console desenvolvida em **.NET** (C#) projetada para gerenciar regras de negócio básicas de um serviço de cadastro de jogadores. A aplicação simula o perfil de um jogador (`GamerProfile.App`), sendo capaz de:
- Gerar tags de usuário (concatenando nickname e código).
- Calcular a experiência total (XP) do jogador, aplicando bônus por fase concluída.
- Validar a elegibilidade do jogador para participar de partidas ranqueadas (Ranked) com base no seu nível.

O foco principal deste projeto é a aplicação prática de **Testes Unitários** para garantir a qualidade e o funcionamento correto de cada uma dessas regras de negócio.

## 🧪 Tipos de Testes Unitários Realizados
Os testes foram escritos no projeto `GamerProfile.Tests` utilizando o framework **xUnit**. Foram validados três cenários distintos com diferentes tipos de retorno e asserções:

1. **Teste de Retorno de Texto (`string`):** 
   - **Método:** `GerarTagUsuario`
   - **Validação:** Verifica se a formatação da tag está correta utilizando `Assert.Equal("Nickname#Codigo", resultado)`.
2. **Teste de Cálculo Matemático (`int`):**
   - **Método:** `CalcularXPTotal`
   - **Validação:** Garante que a soma do XP de duas fases mais o bônus fixo de 100 pontos ocorre corretamente, utilizando `Assert.Equal(valorEsperado, resultado)`.
3. **Teste de Condição Lógica (`bool`):**
   - **Método:** `EEligivelParaRanked`
   - **Validação:** Testa as regras de elegibilidade, utilizando `Assert.True` para validar níveis maiores ou iguais a 15, e `Assert.False` para níveis inferiores.

## 🚀 Instruções para Executar os Testes

Para rodar a aplicação e verificar se todos os testes estão passando, certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina e siga os passos abaixo:

1. Clone este repositório:
   ```bash
   git clone [https://github.com/SEU_USUARIO/gamer-profile-xunit.git](https://github.com/IcaroFeroliv/gamer-profile-xunit/)
   ```
2. Navegue até a pasta raiz da solução:
   ```bash
   cd gamer-profile-xunit
   ```
3. Execute o comando de testes do .NET CLI:
   ```bash
   dotnet test
   ```

O terminal exibirá o resultado da execução, indicando se os testes foram aprovados (`Passed`) ou se houve alguma falha.

---
*Desenvolvido para a lista de exercícios de Gestão e Qualidade de Software.*
