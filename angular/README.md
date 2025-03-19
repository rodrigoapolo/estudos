# Guia de Instalação do NVM, Node.js, Angular CLI e TypeScript

Este guia descreve os passos para instalar e gerenciar diferentes versões do Node.js usando o NVM (Node Version Manager) no Windows, além da instalação do Angular CLI e do TypeScript.

## Passo 1: Verificar a instalação do NVM
Após instalar o NVM, abra o PowerShell ou o Prompt de Comando e execute o seguinte comando para verificar se a instalação foi concluída corretamente:
```sh
nvm -v
```
Se o comando retornar um número de versão, significa que o NVM foi instalado com sucesso.

## Passo 2: Instalar o Node.js
Você pode instalar diferentes versões do Node.js usando o NVM.

- Para instalar a versão mais recente do Node.js, execute:
  ```sh
  nvm install latest
  ```
- Para instalar a versão LTS (Long Term Support) do Node.js, execute:
  ```sh
  nvm install lts
  ```
- Para instalar uma versão específica do Node.js:
  1. Liste as versões disponíveis:
     ```sh
     nvm list available
     ```
  2. Escolha a versão desejada e instale-a. Por exemplo, para instalar a versão 14.20.0:
     ```sh
     nvm install 14.20.0
     ```

## Passo 3: Verificar versões do Node.js instaladas
Para ver as versões do Node.js que você já instalou em sua máquina, execute:
```sh
nvm list
```

## Passo 4: Utilizar uma versão específica do Node.js
Após instalar diferentes versões do Node.js, você pode alternar entre elas utilizando:

- Para usar a versão mais recente instalada:
  ```sh
  nvm use latest
  ```
- Para usar a versão LTS instalada:
  ```sh
  nvm use lts
  ```
- Para usar uma versão específica que já foi instalada:
  ```sh
  nvm use version-number
  ```
  Exemplo:
  ```sh
  nvm use 14.20.0
  ```

## Passo 5: Instalar o Angular CLI
Para instalar o Angular CLI globalmente, utilize o seguinte comando:
```sh
npm install -g @angular/cli@14
```
Isso instalará a versão 14 do Angular CLI.

## Passo 6: Instalar o TypeScript
Para instalar o TypeScript globalmente, execute:
```sh
npm install -g typescript@4.8
```
Para instalar o TypeScript como uma dependência de desenvolvimento no seu projeto, utilize:
```sh
npm install typescript@4.8 --save-dev
```

## Passo 7: Verificar a instalação do TypeScript
Para verificar se o TypeScript foi instalado corretamente e qual versão está instalada, execute:
```sh
tsc --version
```
Se o comando retornar um número de versão, o TypeScript foi instalado com sucesso.

---
Agora você está pronto para trabalhar com Node.js, Angular e TypeScript em sua máquina Windows!

