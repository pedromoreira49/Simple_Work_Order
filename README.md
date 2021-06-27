# Simple Work Order

O intuíto deste software foi automatizar tarefas do meu cotidiano trabalhando em uma empresa que faz uso de Ordens de Serviços para organizar e identificar os serviços de seus devidos clientes.

As Dependências usadas para o desenvolvimento deste software foram:\
--Banco de dados Sqlite (System.Data.SQLite)\
--Gerador de PDF (iTextSharp)\

## Interface principal do sistema:

![image](/Example.png)

Possui 6 botões e 6 campos:

## Campos:
Client: Nome do cliente\
WorkID: ID da ordem de serviço. (nunca deverá começar com 0)\
Contact: Número para contato do cliente\
Equip: Equipamento/peça deixado para ser trabalhado/desenvolvido\
Work: Serviço prestado para o cliente\
Price: Valor a ser cobrado pelo serviço\

## Botões:
Botão Register -> Registrar ordens de serviços no banco de dados.\
Botão Search -> Procurar ordens de serviços registradas pelo Nome do cliente.\
Botão Refresh -> Atualizar a table do DataGridView para as últimas alterações feitas no banco de dados.\
Botão Trash -> Deletar ordens de serviço informando o ID.\
Botão Print -> Gerar um arquivo PDF no diretório workorders\
Botão Update -> Alterar dados do banco de dados. Este botão chamará um formulário com os mesmos campos listados anteriormente.\

## Interface do Formulário de Update:
![image2](/Example2.png)

## PDF

Após informar o ID da ordem de serviço para gerar o pdf, será mostrado uma caixa de mensagem informando que a ordem de serviço foi gerada com sucesso, ou se já exisistia no diretório.\

## Modelo da ordem de serviço:

![image3](/Example3.png)

## Logo

A logo da ordem de serviço deve ser alterada da seguinte forma:\
Salve a imagem da sua logo em formato .png no diretório images, com o nome exatamente assim "minha-logo.png".
