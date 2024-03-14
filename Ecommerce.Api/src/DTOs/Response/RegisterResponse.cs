using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.src.DTOs.Response;

    public record RegisterResponse
    {
        public bool Sucesso { get; private set; }
        public List<string> Erros { get; private set; }

        public RegisterResponse() =>
            Erros = new List<string>();

        public RegisterResponse(bool sucesso = true) : this() =>
            Sucesso = sucesso;

        public void AdicionarErros(IEnumerable<string> erros) =>
            Erros.AddRange(erros);
    }
