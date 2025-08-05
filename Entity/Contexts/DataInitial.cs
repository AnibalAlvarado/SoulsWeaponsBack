using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Contexts
{
    internal class DataInitial
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
              new Card
              {
                  Id = 1,
                  Name = "Espada Larga",
                  Code = "A1",
                  Image = "assets/armas.png",
                  Damage = 65m,
                  FireDamage = 67.5m,
                  ElectricDamage = 63.0m,
                  CrtiticalDamage = 72.0m,
                  PoisionDamage = 31.5m,
                  MagicDamage = 10m,
                  Asset = true,
                  IsDeleted = false
              },


              new Card
              {
                  Id = 2,
                  Name = "Claymore",
                  Code = "A2",
                  Image = "assets/armas.png",
                  Damage = 85m,
                  FireDamage = 45.0m,
                  ElectricDamage = 76.5m,
                  CrtiticalDamage = 81.0m,
                  PoisionDamage = 63.0m,
                  MagicDamage = 20m,
                  Asset = true,
                  IsDeleted = false

              },

              new Card
              {
                  Id = 3,
                  Name = "Daga de Bandido",
                  Code = "A3",
                  Image = "assets/armas.png",
                  Damage = 45m,
                  FireDamage = 85.5m,
                  ElectricDamage = 27.0m,
                  CrtiticalDamage = 54.0m,
                  PoisionDamage = 13.5m,
                  MagicDamage = 10m,
                  Asset = true,
                  IsDeleted = false

              },
              new Card
              {
                  Id = 4,
                  Name = "Hacha de Batalla",
                  Code = "A4",
                  Image = "assets/armas.png",
                  Damage = 90m,
                  FireDamage = 40.5m,
                  ElectricDamage = 49.5m,
                  CrtiticalDamage = 76.5m,
                  PoisionDamage = 58.5m,
                  MagicDamage = 20m,
                  Asset = true,
                  IsDeleted = false


              },
              new Card
              {
                  Id = 5,
                  Name = "Lanza de Plata",
                  Code = "A5",
                  Image = "assets/armas.png",
                  Damage = 70m,
                  FireDamage = 58.5m,
                  ElectricDamage = 81.0m,
                  CrtiticalDamage = 67.5m,
                  PoisionDamage = 40.5m,
                  MagicDamage = 20m,
                  Asset = true,
                  IsDeleted = false


              },
              new Card
              {
                  Id = 6,
                  Name = "Arco Largo",
                  Code = "A6",
                  Image = "assets/armas.png",
                  Damage = 60m,
                  FireDamage = 36.0m,
                  ElectricDamage = 90.0m,
                  CrtiticalDamage = 63.0m,
                  PoisionDamage = 27.0m,
                  MagicDamage = 10m,
                  Asset = true,
                  IsDeleted = false

              },
               new Card
               {
                   Id = 7,
                   Name = "Martillo de Guerra",
                   Code = "A7",
                   Image = "assets/armas.png",
                   Damage = 95m,
                   FireDamage = 31.5m,
                   ElectricDamage = 54.0m,
                   CrtiticalDamage = 85.5m,
                   PoisionDamage = 76.5m,
                   MagicDamage = 30m,
                   Asset = true,
                   IsDeleted = false


               },
                new Card
                {
                    Id = 8,
                    Name = "Katana de Uchigatana",
                    Code = "A8",
                    Image = "assets/armas.png",
                    Damage = 75m,
                    FireDamage = 76.5m,
                    ElectricDamage = 58.5m,
                    CrtiticalDamage = 58.5m,
                    PoisionDamage = 36.0m,
                    MagicDamage = 20m,
                    Asset = true,
                    IsDeleted = false
                },
                 new Card
                 {
                     Id = 9,
                     Name = "Bastón del Hechicero",
                     Code = "B1",
                     Image = "assets/armas.png",
                     Damage = 80m,
                     FireDamage = 54.0m,
                     ElectricDamage = 67.5m,
                     CrtiticalDamage = 45.0m,
                     PoisionDamage = 22.5m,
                     MagicDamage = 30m,
                     Asset = true,
                     IsDeleted = false

                 },
                  new Card
                  {
                      Id = 10,
                      Name = "Espadón Negro",
                      Code = "B2",
                      Image = "assets/armas.png",
                      Damage = 100m,
                      FireDamage = 27.0m,
                      ElectricDamage = 72.0m,
                      CrtiticalDamage = 76.5m,
                      PoisionDamage = 81.0m,
                      MagicDamage = 40m,
                      Asset = true,
                      IsDeleted = false

                  },
                   new Card
                   {
                       Id = 11,
                       Name = "Cimitarra",
                       Code = "B3",
                       Image = "assets/armas.png",
                       Damage = 55m,
                       FireDamage = 81.0m,
                       ElectricDamage = 45.0m,
                       CrtiticalDamage = 63.0m,
                       PoisionDamage = 22.5m,
                       MagicDamage = 10m,
                       Asset = true,
                       IsDeleted = false

                   },
                    new Card
                    {
                        Id = 12,
                        Name = "Lanza del Dragón",
                        Code = "B4",
                        Image = "assets/armas.png",
                        Damage = 95m,
                        FireDamage = 45.0m,
                        ElectricDamage = 85.5m,
                        CrtiticalDamage = 54.0m,
                        PoisionDamage = 49.5m,
                        MagicDamage = 40m,
                        Asset = true,
                        IsDeleted = false
                    },
                     new Card
                     {
                         Id = 13,
                         Name = "Ballesta Pesada",
                         Code = "B5",
                         Image = "assets/armas.png",
                         Damage = 85m,
                         FireDamage = 22.5m,
                         ElectricDamage = 81.0m,
                         CrtiticalDamage = 72.0m,
                         PoisionDamage = 54.0m,
                         MagicDamage = 20m,
                         Asset = true,
                         IsDeleted = false

                     },
                     new Card
                     {
                         Id = 14,
                         Name = "Daga de Parry",
                         Code = "B6",
                         Image = "assets/armas.png",
                         Damage = 40m,
                         FireDamage = 90.0m,
                         ElectricDamage = 22.5m,
                         CrtiticalDamage = 49.5m,
                         PoisionDamage = 9.0m,
                         MagicDamage = 20m,
                         Asset = true,
                         IsDeleted = false


                     },
                     new Card
                     {
                         Id = 15,
                         Name = "Espada Flamberge",
                         Code = "B7",
                         Image = "assets/armas.png",
                         Damage = 80m,
                         FireDamage = 49.5m,
                         ElectricDamage = 67.5m,
                         CrtiticalDamage = 67.5m,
                         PoisionDamage = 45.0m,
                         MagicDamage = 30m,
                         Asset = true,
                         IsDeleted = false

                     },
                      new Card
                      {
                          Id = 16,
                          Name = "Hacha Demoniaca",
                          Code = "B8",
                          Image = "assets/armas.png",
                          Damage = 105m,
                          FireDamage = 36.0m,
                          ElectricDamage = 45.0m,
                          CrtiticalDamage = 81.0m,
                          PoisionDamage = 72.0m,
                          MagicDamage = 40m,
                          Asset = true,
                          IsDeleted = false


                      },
                      new Card
                      {
                          Id = 17,
                          Name = "Arco Compuesto",
                          Code = "C1",
                          Image = "assets/armas.png",
                          Damage = 70m,
                          FireDamage = 54.0m,
                          ElectricDamage = 85.5m,
                          CrtiticalDamage = 58.5m,
                          PoisionDamage = 31.5m,
                          MagicDamage = 20m,
                          Asset = true,
                          IsDeleted = false


                      },
                      new Card
                      {
                          Id = 18,
                          Name = "Maza de Hierro",
                          Code = "C2",
                          Image = "assets/armas.png",
                          Damage = 75m,
                          FireDamage = 45.0m,
                          ElectricDamage = 40.5m,
                          CrtiticalDamage = 81.0m,
                          PoisionDamage = 49.5m,
                          MagicDamage = 10m,
                          Asset = true,
                          IsDeleted = false



                      },
                      new Card
                      {
                          Id = 19,
                          Name = "Espada Cristalina",
                          Code = "C3",
                          Image = "assets/armas.png",
                          Damage = 110m,
                          FireDamage = 58.5m,
                          ElectricDamage = 63.0m,
                          CrtiticalDamage = 22.5m,
                          PoisionDamage = 40.5m,
                          MagicDamage = 40m,
                          Asset = true,
                          IsDeleted = false

                      },
                       new Card
                       {
                           Id = 20,
                           Name = "Garra de Lobo",
                           Code = "C4",
                           Image = "assets/armas.png",
                           Damage = 60m,
                           FireDamage = 76.5m,
                           ElectricDamage = 31.5m,
                           CrtiticalDamage = 58.5m,
                           PoisionDamage = 18.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 21,
                           Name = "Bastón de Llamas",
                           Code = "C5",
                           Image = "assets/armas.png",
                           Damage = 85m,
                           FireDamage = 49.5m,
                           ElectricDamage = 72.0m,
                           CrtiticalDamage = 40.5m,
                           PoisionDamage = 27.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 22,
                           Name = "Espada del Caballero Negro",
                           Code = "C6",
                           Image = "assets/armas.png",
                           Damage = 95m,
                           FireDamage = 40.5m,
                           ElectricDamage = 67.5m,
                           CrtiticalDamage = 72.0m,
                           PoisionDamage = 58.5m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 23,
                           Name = "Puñales Gemelos",
                           Code = "C7",
                           Image = "assets/armas.png",
                           Damage = 50m,
                           FireDamage = 85.5m,
                           ElectricDamage = 27.0m,
                           CrtiticalDamage = 54.0m,
                           PoisionDamage = 18.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 24,
                           Name = "Lanza de Plata Divina",
                           Code = "C8",
                           Image = "assets/armas.png",
                           Damage = 90m,
                           FireDamage = 54.0m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 63.0m,
                           PoisionDamage = 45.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 25,
                           Name = "Martillo del Titán",
                           Code = "D1",
                           Image = "assets/armas.png",
                           Damage = 120m,
                           FireDamage = 18.0m,
                           ElectricDamage = 49.5m,
                           CrtiticalDamage = 90.0m,
                           PoisionDamage = 90.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false



                       },
                       new Card
                       {
                           Id = 26,
                           Name = "Arco de Cazador",
                           Code = "D2",
                           Image = "assets/armas.png",
                           Damage = 65m,
                           FireDamage = 63.0m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 67.5m,
                           PoisionDamage = 22.5m,
                           MagicDamage = 10m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 27,
                           Name = "Espada Maldita",
                           Code = "D3",
                           Image = "assets/armas.png",
                           Damage = 100m,
                           FireDamage = 63.0m,
                           ElectricDamage = 58.5m,
                           CrtiticalDamage = 36.0m,
                           PoisionDamage = 40.5m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 28,
                           Name = "Alabarda",
                           Code = "D4",
                           Image = "assets/armas.png",
                           Damage = 85m,
                           FireDamage = 36.0m,
                           ElectricDamage = 90.0m,
                           CrtiticalDamage = 76.5m,
                           PoisionDamage = 67.5m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 29,
                           Name = "Estoque",
                           Code = "D5",
                           Image = "assets/armas.png",
                           Damage = 55m,
                           FireDamage = 72.0m,
                           ElectricDamage = 63.0m,
                           CrtiticalDamage = 58.5m,
                           PoisionDamage = 22.5m,
                           MagicDamage = 10m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 30,
                           Name = "Hacha Gigante",
                           Code = "D6",
                           Image = "assets/armas.png",
                           Damage = 110m,
                           FireDamage = 22.5m,
                           ElectricDamage = 54.0m,
                           CrtiticalDamage = 85.5m,
                           PoisionDamage = 85.5m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 31,
                           Name = "Bastón de Hielo",
                           Code = "D7",
                           Image = "assets/armas.png",
                           Damage = 75m,
                           FireDamage = 58.5m,
                           ElectricDamage = 67.5m,
                           CrtiticalDamage = 49.5m,
                           PoisionDamage = 27.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 32,
                           Name = "Cuchillo Arrojadizo",
                           Code = "D8",
                           Image = "assets/armas.png",
                           Damage = 45m,
                           FireDamage = 81.0m,
                           ElectricDamage = 54.0m,
                           CrtiticalDamage = 27.0m,
                           PoisionDamage = 13.5m,
                           MagicDamage = 10m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 33,
                           Name = "Espada de Moonlight",
                           Code = "E1",
                           Image = "assets/armas.png",
                           Damage = 105m,
                           FireDamage = 54.0m,
                           ElectricDamage = 72.0m,
                           CrtiticalDamage = 54.0m,
                           PoisionDamage = 49.5m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 34,
                           Name = "Lanza Alada",
                           Code = "E2",
                           Image = "assets/armas.png",
                           Damage = 70m,
                           FireDamage = 67.5m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 63.0m,
                           PoisionDamage = 36.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 35,
                           Name = "Martillo del Caos",
                           Code = "E3",
                           Image = "assets/armas.png",
                           Damage = 115m,
                           FireDamage = 27.0m,
                           ElectricDamage = 45.0m,
                           CrtiticalDamage = 76.5m,
                           PoisionDamage = 81.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 36,
                           Name = "Ballesta Ligera",
                           Code = "E4",
                           Image = "assets/armas.png",
                           Damage = 60m,
                           FireDamage = 63.0m,
                           ElectricDamage = 72.0m,
                           CrtiticalDamage = 63.0m,
                           PoisionDamage = 31.5m,
                           MagicDamage = 10m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 37,
                           Name = "Espada Curva",
                           Code = "E5",
                           Image = "assets/armas.png",
                           Damage = 65m,
                           FireDamage = 76.5m,
                           ElectricDamage = 49.5m,
                           CrtiticalDamage = 67.5m,
                           PoisionDamage = 31.5m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 38,
                           Name = "Látigo Espinoso",
                           Code = "E6",
                           Image = "assets/armas.png",
                           Damage = 55m,
                           FireDamage = 67.5m,
                           ElectricDamage = 85.5m,
                           CrtiticalDamage = 45.0m,
                           PoisionDamage = 27.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 39,
                           Name = "Bastón del Archimago",
                           Code = "E7",
                           Image = "assets/armas.png",
                           Damage = 95m,
                           FireDamage = 45.0m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 36.0m,
                           PoisionDamage = 31.5m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 40,
                           Name = "Hacha de Ejecutor",
                           Code = "E8",
                           Image = "assets/armas.png",
                           Damage = 100m,
                           FireDamage = 31.5m,
                           ElectricDamage = 58.5m,
                           CrtiticalDamage = 81.0m,
                           PoisionDamage = 72.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 41,
                           Name = "Daga Venenosa",
                           Code = "F1",
                           Image = "assets/armas.png",
                           Damage = 50m,
                           FireDamage = 81.0m,
                           ElectricDamage = 31.5m,
                           CrtiticalDamage = 49.5m,
                           PoisionDamage = 18.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 42,
                           Name = "Arco del Cazador de Dragones",
                           Code = "F2",
                           Image = "assets/armas.png",
                           Damage = 90m,
                           FireDamage = 40.5m,
                           ElectricDamage = 90.0m,
                           CrtiticalDamage = 58.5m,
                           PoisionDamage = 45.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 43,
                           Name = "Espada del Crepúsculo",
                           Code = "F3",
                           Image = "assets/armas.png",
                           Damage = 85m,
                           FireDamage = 63.0m,
                           ElectricDamage = 63.0m,
                           CrtiticalDamage = 63.0m,
                           PoisionDamage = 40.5m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 44,
                           Name = "Tridente de Poseidón",
                           Code = "F4",
                           Image = "assets/armas.png",
                           Damage = 80m,
                           FireDamage = 54.0m,
                           ElectricDamage = 81.0m,
                           CrtiticalDamage = 67.5m,
                           PoisionDamage = 49.5m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false
                       },
                       new Card
                       {
                           Id = 45,
                           Name = "Maza de Plata",
                           Code = "F5",
                           Image = "assets/armas.png",
                           Damage = 70m,
                           FireDamage = 49.5m,
                           ElectricDamage = 45.0m,
                           CrtiticalDamage = 76.5m,
                           PoisionDamage = 45.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 46,
                           Name = "Espada de Llamas",
                           Code = "F6",
                           Image = "assets/armas.png",
                           Damage = 90m,
                           FireDamage = 58.5m,
                           ElectricDamage = 58.5m,
                           CrtiticalDamage = 54.0m,
                           PoisionDamage = 36.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 47,
                           Name = "Guja",
                           Code = "F7",
                           Image = "assets/armas.png",
                           Damage = 75m,
                           FireDamage = 45.0m,
                           ElectricDamage = 85.5m,
                           CrtiticalDamage = 72.0m,
                           PoisionDamage = 54.0m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 48,
                           Name = "Espada Bastarda",
                           Code = "F8",
                           Image = "assets/armas.png",
                           Damage = 80m,
                           FireDamage = 54.0m,
                           ElectricDamage = 67.5m,
                           CrtiticalDamage = 76.5m,
                           PoisionDamage = 49.5m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 49,
                           Name = "Ballesta del Asesino",
                           Code = "G1",
                           Image = "assets/armas.png",
                           Damage = 75m,
                           FireDamage = 72.0m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 45.0m,
                           PoisionDamage = 27.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 50,
                           Name = "Martillo de Tormenta",
                           Code = "G2",
                           Image = "assets/armas.png",
                           Damage = 105m,
                           FireDamage = 36.0m,
                           ElectricDamage = 49.5m,
                           CrtiticalDamage = 81.0m,
                           PoisionDamage = 76.5m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 51,
                           Name = "Daga de Sombras",
                           Code = "G3",
                           Image = "assets/armas.png",
                           Damage = 60m,
                           FireDamage = 85.5m,
                           ElectricDamage = 36.0m,
                           CrtiticalDamage = 40.5m,
                           PoisionDamage = 16.2m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 52,
                           Name = "Espada del Alma",
                           Code = "G4",
                           Image = "assets/armas.png",
                           Damage = 110m,
                           FireDamage = 49.5m,
                           ElectricDamage = 67.5m,
                           CrtiticalDamage = 45.0m,
                           PoisionDamage = 45.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false


                       },
                       new Card
                       {
                           Id = 53,
                           Name = "Lanza de Hueso",
                           Code = "G5",
                           Image = "assets/armas.png",
                           Damage = 65m,
                           FireDamage = 63.0m,
                           ElectricDamage = 76.5m,
                           CrtiticalDamage = 54.0m,
                           PoisionDamage = 31.5m,
                           MagicDamage = 20m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 54,
                           Name = "Bastón de Rayo",
                           Code = "G6",
                           Image = "assets/armas.png",
                           Damage = 100m,
                           FireDamage = 40.5m,
                           ElectricDamage = 81.0m,
                           CrtiticalDamage = 31.5m,
                           PoisionDamage = 36.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 55,
                           Name = "Hacha de Carnicero",
                           Code = "G7",
                           Image = "assets/armas.png",
                           Damage = 95m,
                           FireDamage = 45.0m,
                           ElectricDamage = 40.5m,
                           CrtiticalDamage = 72.0m,
                           PoisionDamage = 63.0m,
                           MagicDamage = 30m,
                           Asset = true,
                           IsDeleted = false

                       },
                       new Card
                       {
                           Id = 56,
                           Name = "Espada del Destino",
                           Code = "G8",
                           Image = "assets/armas.png",
                           Damage = 120m,
                           FireDamage = 45.0m,
                           ElectricDamage = 72.0m,
                           CrtiticalDamage = 63.0m,
                           PoisionDamage = 54.0m,
                           MagicDamage = 40m,
                           Asset = true,
                           IsDeleted = false

                       }

            );


        }
    }
}
