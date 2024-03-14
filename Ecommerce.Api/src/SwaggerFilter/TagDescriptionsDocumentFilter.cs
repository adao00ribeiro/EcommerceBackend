using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Ecommerce.Api.src.SwaggerFilter;

public class TagDescriptionsDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Tags = new List<OpenApiTag> {
            new OpenApiTag { Name = "Identity", Description = "A categoria de Identidade engloba funcionalidades relacionadas à autenticação de usuários, registro e processos de login dentro de um aplicativo de software. Ela gerencia credenciais de usuário, permissões e controle de acesso, garantindo o acesso seguro aos recursos do sistema." },
            new OpenApiTag { Name = "Category", Description = "A Categoria envolve a gestão e organização de produtos ou itens em grupos ou categorias distintas. Ela permite que os usuários naveguem pelo catálogo de produtos de forma mais eficiente, agrupando itens similares juntos. Essa funcionalidade muitas vezes inclui recursos para criar, editar e excluir categorias, bem como associar produtos às categorias relevantes." },
            new OpenApiTag { Name = "Product", Description = "Esta categoria foca em navegar e gerenciar o catálogo de produtos dentro de um aplicativo. Ela fornece recursos para os usuários verem listagens de produtos, procurarem por itens específicos, filtrarem produtos com base em vários critérios e realizarem ações como adicionar itens ao carrinho de compras ou lista de desejos. Além disso, as funcionalidades de gerenciamento de produtos permitem que administradores adicionem, editem ou removam produtos do catálogo." },
            new OpenApiTag { Name = "Cart", Description = "A categoria de Carrinho envolve a gestão da funcionalidade de carrinho de compras dentro de um aplicativo de comércio eletrônico ou varejo. Ela permite que os usuários adicionem produtos ao carrinho, ajustem quantidades, removam itens e avancem para o checkout para concluir a compra. As funcionalidades de gerenciamento de carrinho também incluem recursos como exibir custos subtotal, aplicar descontos ou cupons e salvar carrinhos para sessões futuras." },
            new OpenApiTag { Name = "Coupon", Description = "Cupons são um subconjunto de ofertas promocionais ou descontos fornecidos aos usuários para uso durante o checkout. A categoria de Cupom envolve a criação, gestão e aplicação de códigos de cupom dentro do aplicativo. Esta funcionalidade inclui gerar códigos de cupom únicos, especificar valores ou porcentagens de desconto, definir datas de validade e aplicar regras de validação para garantir o uso correto de cupons pelos clientes." }
        };

    }
}
