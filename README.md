# Marquinho — Lavagens Leves e Pesadas

Landing page do **Marquinho Lavagens**, um lava rápido em Mairinque/SP que lava de moto a carreta.

O site existe para uma coisa só: fazer o cliente chamar no WhatsApp. Ele mostra a tabela de valores, os serviços para pesados e de estética automotiva, e o endereço. Todo botão leva para uma conversa já com a mensagem pronta.

## O que tem na página

- **Início:** apresentação ("Da moto à carreta.") e botão de agendamento
- **Serviços:** tabela de valores para motos e carros pequenos, médios e grandes
- **Linha pesada:** caminhões, carretas, baús, siders, ônibus e vans (orçamento pelo WhatsApp)
- **Estética automotiva:** vitrificação, polimento, martelinho de ouro e higienização (orçamento pelo WhatsApp)
- **Diferenciais:** os quatro motivos para escolher o Marquinho
- **Como funciona:** chamar, combinar o horário e retirar o veículo
- **Frotas:** atendimento recorrente para transportadoras e empresas da região
- **Contato:** telefone, horário, endereço e link para o Google Maps

Também tem tema claro e escuro (a escolha fica salva no navegador), menu para celular, botão flutuante do WhatsApp e animações de entrada. As animações são desligadas para quem ativou "reduzir movimento" no sistema.

## Tabela de valores

| Veículo        | Serviço           | Valor  |
|----------------|-------------------|--------|
| Moto           | Lavagem simples   | R$ 20  |
| Moto           | Lavagem completa  | R$ 40  |
| Moto           | Lavagem detalhada | R$ 150 |
| Carro pequeno  | Cera líquida      | R$ 80  |
| Carro pequeno  | Cera em pasta     | R$ 150 |
| Carro pequeno  | Lavagem completa  | R$ 150 |
| Carro médio    | Cera líquida      | R$ 100 |
| Carro médio    | Cera em pasta     | R$ 150 |
| Carro médio    | Lavagem completa  | R$ 150 |
| Carro grande   | Cera líquida      | R$ 100 |
| Carro grande   | Cera em pasta     | R$ 200 |
| Carro grande   | Lavagem completa  | R$ 200 |

A lavagem completa inclui motor e lavagem por baixo. Picapes RAM, pesados e estética automotiva têm valor sob consulta.

## Tecnologia

É um único arquivo, o `index.html`, com HTML, CSS e JavaScript puros. Não precisa instalar nada nem rodar build. As imagens do logo estão embutidas no próprio arquivo, e as fontes (Saira, Saira Condensed e Chakra Petch) vêm do Google Fonts.

## Como rodar

Abra o `index.html` no navegador. Se quiser servir localmente:

```bash
python3 -m http.server 8000
# acesse http://localhost:8000
```

## Como publicar

Como é um site estático, ele roda em qualquer hospedagem gratuita:

- **GitHub Pages:** em *Settings → Pages*, escolha a branch `main` e a pasta `/ (root)`
- **Netlify** ou **Vercel:** importe o repositório, sem comando de build

## Como atualizar o conteúdo

Tudo é editado direto no `index.html`:

- **Preços:** procure por `price-row` e altere o número dentro de `<span class="val">`
- **WhatsApp:** o número aparece nos links `https://wa.me/5511998245254`. Para trocar, substitua `5511998245254` em todos eles (DDI + DDD + número, sem espaços). A mensagem pronta fica no parâmetro `?text=`
- **Horário e endereço:** na seção `id="contato"`
- **Cores:** nas variáveis do bloco `:root` no começo do CSS (`--neon` é o azul da marca). O tema claro fica em `:root[data-theme="light"]`

## Contato

- **WhatsApp / Telefone:** (11) 99824-5254
- **Endereço:** Estr. Gov. Mário Covas, 10200, Moreiras, Mairinque/SP
- **Horário:** segunda a sábado, das 8h às 18h. Domingos e feriados sob consulta

## Licença

Código sob licença [MIT](LICENSE). O nome e o logo do Marquinho Lavagens pertencem ao estabelecimento.
