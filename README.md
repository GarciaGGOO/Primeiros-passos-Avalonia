# Avalonia UI - Conversor de Temperatura

Este é um exemplo simples de um conversor de temperatura desenvolvido com Avalonia UI. Ele permite converter temperaturas de Celsius para Fahrenheit em tempo real.

## Funcionalidades

- Conversão de temperatura de Celsius para Fahrenheit.
- Atualização automática do resultado ao digitar a temperatura em Celsius.

## Pré-requisitos

- [.NET 6.0 ou superior](https://dotnet.microsoft.com/download/dotnet)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) ou [Visual Studio Code](https://code.visualstudio.com/) com [Extensão AvaloniaUI](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaforVisualStudioCode)

## Como Configurar

1. **Clonar o Repositório**:
    ```sh
    git clone https://github.com/GarciaGGOO/Primeiros-passos-Avalonia.git
    cd Primeiros-passos-Avalonia
    ```

2. **Restaurar os Pacotes**:
    ```sh
    dotnet restore
    ```

3. **Executar o Projeto**:
    ```sh
    dotnet run
    ```

4. **Testar o Conversor de Temperatura**:
    - Ao abrir o aplicativo, insira a temperatura em Celsius no campo correspondente.
    - O resultado em Fahrenheit será atualizado automaticamente.

## Estrutura do Projeto

O projeto segue a estrutura padrão de uma aplicação Avalonia:

- `MainView.axaml`: Define a interface gráfica da aplicação.
- `MainView.axaml.cs`: Contém a lógica de código por trás da interface.
- `App.xaml`: Arquivo de inicialização da aplicação.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para sugerir melhorias ou corrigir problemas.
