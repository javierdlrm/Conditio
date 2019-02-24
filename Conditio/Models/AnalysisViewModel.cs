using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conditio.Models
{
    public class AnalysisViewModel
    {
        public string Url { get; set; }

        public TermsModel Terms { get; set; }

        public Dictionary<string, List<TermsModel>> TermsDictionary { get; set; } = new Dictionary<string, List<TermsModel>>()
        {
            {
                "pccomponentes.com",
                new List<TermsModel>() {
                    new TermsModel()
                    {
                        Key = "General",
                        Name = "General",
                        Price = new KeyValuePair<string, int>(
                            "Formas de pago: tarjeta, transferencia, financiación, contrareembolso, en metálico o con tarjeta",
                            2),
                        Delivery = new KeyValuePair<string, int>(
                            "Entre 24 horas y 72 horas",
                            1),
                        Refund = new KeyValuePair<string, int>(
                            "Plazo máximo de 14 días",
                            2),
                        Cancelation = new KeyValuePair<string, int>(
                            "30 días",
                            1),
                        Guarantee = new KeyValuePair<string, int>(
                            "2 años desde el momento de la compra",
                            1),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "Normativa española vigente. Cualquier controversia se someterá a los Juzgados y Tribunales españoles",
                            1),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "TRLGDCU, LSSI",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "PC COMPONENTES Y MULTIMEDIA, S.L.U. , sociedad española, con NIF B73347494",
                            1),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "Sesión - Persistentes - Propias - Terceros - Análisis",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "Calificación general superior a la media",
                            1)
                    },
                    new TermsModel()
                    {
                        Key = "televisor-sony-kd65xe9005-65-led-ultra-hd-4k",
                        Name = "Televisor Sony KD65XE9005 65\" LED UltraHD 4K",
                        Price = new KeyValuePair<string, int>(
                            "1719 euros. Financiación disponible.",
                            1),
                        Delivery = new KeyValuePair<string, int>(
                            "Desde 17,50€ GRATIS con PcComponentes Premium. Disponibilidad: antes del martes 26 y le miércoles 27 febrero.",
                            3),
                        Refund = new KeyValuePair<string, int>(
                            "",
                            2),
                        Cancelation = new KeyValuePair<string, int>(
                            "",
                            1),
                        Guarantee = new KeyValuePair<string, int>(
                            "",
                            1),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "",
                            1),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "",
                            1),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "",
                            1)
                    },
                    new TermsModel()
                    {
                        Key = "hp-pavilion-15-bc450ns-intel-core-i5-8300h-8gb-1tb-128gb-ssd-gtx-1050-156",
                        Name = "HP Pavilion 15-BC450NS Intel Core i5-8300H/8GB/1TB+128GB SSD/GTX 1050/15.6",
                        Price = new KeyValuePair<string, int>(
                            "669 Euros. Financiación disponbile: 6,12,20, y 30 meses.",
                            1),
                        Delivery = new KeyValuePair<string, int>(
                            "¡¡Envio gratis!! No aplicable a clientes de Canarias, Ceuta, Melilla y Baleares",
                            1),
                        Refund = new KeyValuePair<string, int>(
                            "",
                            2),
                        Cancelation = new KeyValuePair<string, int>(
                            "",
                            1),
                        Guarantee = new KeyValuePair<string, int>(
                            "",
                            1),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "",
                            1),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "",
                            1),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "",
                            1)
                    }
                }
            },




            {
                "asos.com",
                new List<TermsModel>() {
                    new TermsModel()
                    {
                        Key = "General",
                        Name = "General",
                        Price = new KeyValuePair<string, int>(
                            "Igualamiento de precios a productos mas baratos",
                            1),
                        Delivery = new KeyValuePair<string, int>(
                            "Gratis - 9,95",
                            2),
                        Refund = new KeyValuePair<string, int>(
                            "Hasta 28 días después de haberlo recibido",
                            1),
                        Cancelation = new KeyValuePair<string, int>(
                            "No se realizan, se debe hacer una devolución y realizar un nuevo pedido.",
                            2),
                        Guarantee = new KeyValuePair<string, int>(
                            "No hay garantía",
                            3),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "No específicada, según legislación general de consumidores.",
                            4),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "Ley 3/2014  Ley General para la Defensa de Consumidores y Usuarios;",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "ASOS.com Limited (número de compañía 3584121), una compañía registrada en Inglaterra y Gales.",
                            3),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "Funcionales - Analíticas - Preferencias - Publicitarias",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "Calificación general en torno a la media",
                            2)
                    },
                    new TermsModel()
                    {
                        Key = "es/converse/zapatillas-negras-hi-top-chuck-taylor-all-star-de-converse/prd/4391061?clr=negro&SearchQuery=&cid=6456&gridcolumn=4&gridrow=3&gridsize=4&pge=1&pgesize=72&totalstyles=512",
                        Name = "Televisor Sony KD65XE9005 65\" LED UltraHD 4K",
                        Price = new KeyValuePair<string, int>(
                            "69.99 euros",
                            1),
                        Delivery = new KeyValuePair<string, int>(
                            "Entrega gratis bajo las siguientes condiciones. Este producto se envía solo a países de EEE, EEUU, Rusia y Autralia",
                            2),
                        Refund = new KeyValuePair<string, int>(
                            "Devolución gratis",
                            1),
                        Cancelation = new KeyValuePair<string, int>(
                            "",
                            2),
                        Guarantee = new KeyValuePair<string, int>(
                            "",
                            3),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "",
                            4),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "",
                            1),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "",
                            3),
                        DataProtection = new KeyValuePair<string, int>(
                            "",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "",
                            2)
                    }
                }
            },
        };
    }
}
