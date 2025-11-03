# 🧩 Mini Sudoku (3x3) em C#

Uma implementação em C# da lógica para um jogo de "Mini Sudoku" em uma grade 3x3.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

---

## 🎯 Sobre o Projeto

Este projeto é um exercício de lógica de programação focado em um quebra-cabeça mais simples que o Sudoku tradicional. O objetivo é criar um sistema que gerencia uma **grade 3x3**, onde o objetivo é preencher a grade com os números de 1 a 3, sem repeti-los em nenhuma linha ou coluna.

O projeto é provavelmente uma **aplicação de Console** ou uma **aplicação Desktop (WinForms/WPF)** simples para praticar algoritmos e manipulação de matrizes.

## ✨ Funcionalidades

* **Representação do Tabuleiro:** Uso de uma matriz 2D (3x3) para armazenar o estado do jogo.
* **Validação de Regras:** Funções que verificam se um número (1, 2 ou 3) é válido em uma determinada posição (checa linha e coluna).
* **(Opcional) Algoritmo de Solver:** Implementação de um algoritmo (como backtracking) para encontrar a solução de um tabuleiro incompleto.
* **Interface (Console ou GUI):** Permite ao usuário inserir números ou carregar um tabuleiro.

## 💻 Tecnologias Utilizadas

* **C#:** Linguagem principal para a implementação da lógica e dos algoritmos.
* **.NET Framework (ou .NET Core):** A plataforma de desenvolvimento.
* **Console, WinForms ou WPF:** Para a interface de usuário.

## 🚀 Rodando o Projeto

A forma de execução depende do tipo de projeto (Console ou Desktop):

* **Se for um projeto de Console:**
    ```bash
    # 1. Clone o repositório e acesse a pasta
    cd Sudoku-3x3
    # 2. Compile e execute
    dotnet run
    ```
* **Se for um projeto Desktop (WinForms/WPF):**
    1.  Abra o arquivo de solução (`.sln`) no Visual Studio.
    2.  Pressione "Start" (F5) para compilar e executar.

---
Desenvolvido por **Raul Rodrigues**
