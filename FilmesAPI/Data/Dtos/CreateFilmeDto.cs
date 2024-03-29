﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = " O gênero deve conter no máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = " A duração deve conter de 1 a 600 minutos")]
        public int Duracao { get; set; }
    }
}
