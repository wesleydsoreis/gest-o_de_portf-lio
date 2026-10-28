Plano de Gerência de Configuração de Software (PGC)

1. Identificação do Projeto

Nome: Gestão de Portfólio de Projetos

Repositório: https://github.com/wesleydsoreis/gest-o_de_portf-lio

Tecnologia: C# / .NET

Controle de versão: Git e GitHub

2. Objetivo

Este plano estabelece os procedimentos para organizar, versionar, revisar, verificar e manter os arquivos do projeto Gestão de Portfólio de Projetos, garantindo rastreabilidade das alterações e maior segurança no desenvolvimento.

3. Gerenciamento de Configuração

Os arquivos-fonte, documentos e demais componentes do projeto serão mantidos no repositório GitHub. As alterações deverão ser registradas por meio de commits, permitindo acompanhar o histórico de desenvolvimento.

Arquivos temporários, pastas de compilação e informações sensíveis não deverão ser incluídos no controle de versão.

4. Estratégia de Branches

A branch main será utilizada como versão principal e estável do projeto.

Novas funcionalidades, correções e modificações deverão ser desenvolvidas em branches separadas, criadas a partir da branch principal.

Após a conclusão das alterações, deverá ser aberto um Pull Request para solicitar a integração com a main.

5. Política de Commits

Os commits deverão apresentar mensagens claras e objetivas, descrevendo as alterações realizadas.

Exemplos:

feat: adiciona cadastro de projetos

fix: corrige cálculo de pontuação

docs: atualiza documentação do projeto

ci: configura verificações automatizadas

6. Revisão de Código

As alterações propostas para a branch main deverão passar por um processo de revisão por meio de Pull Requests.

Um colaborador com permissão de escrita deverá participar da revisão das alterações. A integração dependerá da aprovação exigida pelas regras de proteção da branch e da conclusão das verificações configuradas.

7. Integração Contínua (CI)

O projeto utilizará GitHub Actions para automatizar verificações do código-fonte.

O fluxo de integração contínua deverá executar a restauração das dependências e a compilação do projeto com o .NET SDK compatível.

Quando houver testes automatizados disponíveis, eles deverão ser executados no fluxo de verificação.

8. Ambientes

8.1 Staging

O ambiente staging será destinado à validação das alterações antes da liberação final. A execução das verificações automatizadas e a validação do fluxo de integração deverão ocorrer antes da promoção para produção.

8.2 Production

O ambiente production representará a etapa de liberação final do projeto. A promoção para esse ambiente deverá exigir aprovação manual, com o responsável pelo projeto configurado como revisor obrigatório nas regras de proteção do ambiente.

9. Entrega e Manutenção

O repositório deverá permanecer acessível para consulta e avaliação. A documentação e os procedimentos de configuração deverão ser atualizados sempre que houver mudanças relevantes no processo de desenvolvimento.

10. Responsabilidades

O responsável pelo projeto deverá manter a organização do repositório, acompanhar as verificações automatizadas, revisar as alterações propostas e controlar a liberação para produção conforme as regras estabelecidas.

Os colaboradores deverão seguir a estratégia de branches, registrar suas alterações por meio de commits e submeter suas modificações à revisão.

11. Histórico do Documento

Versão

Descrição

1.0

Criação do Plano de Gerência de Configuração de Software
