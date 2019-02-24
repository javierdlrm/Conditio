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
                            "Los precios y condiciones de venta tienen un carácter meramente informativo y pueden ser modificados en atención a las fluctuaciones del mercado.Una vez formalizado el pedido no podrán ser modificados sin el expreso acuerdo de ambos contratantes. Formas de pago: tarjeta, transferencia o ingreso en cuenta, financiación, contrareembolso, en metálico o con tarjeta en Tienda, Google Pay",
                            2),
                        Delivery = new KeyValuePair<string, int>(
                            "Entre 24 horas y 72 horas. Dependerá de la disponibilidad de cada producto. Si hay varios productos, se hará un único envío. El cliente dispondrá de 72 horas para comprobar el pedido. Si el producto está dañado es recomendable contactar en las primeras 24 horas. Gastos de envíos variable: visita nuestra calculadora de gastos de envío .",
                            1),
                        Refund = new KeyValuePair<string, int>(
                            "Te devolveremos el dinero según la forma de pago que hayas utilizado. Toda mercancía debe ser devuelta en su embalaje sin abrir y condiciones originales. Tras rellenar el formulario de desistimiento, deberás enviar los bienes en un plazo máximo de 14 días. Los gastos de transportes originados por la devolución correrán a tu cargo.",
                            2),
                        Cancelation = new KeyValuePair<string, int>(
                            "Desistimiento 14 días naturales desde la recepción sin necesidad de justificar. En la cancelación de pedidos que impliquen  una devolución, ésta podrá tardar hasta 30 días.",
                            1),
                        Guarantee = new KeyValuePair<string, int>(
                            "Con carácter general, el plazo de garantía es 2 años desde el momento de la compra. Posibilidad de garantía extendida. La garantía no cubre defectos provocados por desgaste y/o manipulación del mismo por parte del cliente. PCCOMPONENTES, hará el cambio de su producto por uno idéntico o similar en prestaciones o procederá a su reparación tras la valoración del SAT oficial, Cuando el cambio no sea posible por uno igual, se realizará el cambio por similar en prestaciones/precio",
                            1),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "La relación entre PCCOMPONENTES y el USUARIO se regirá por la normativa española vigente y cualquier controversia se someterá a los Juzgados y Tribunales españolesResolución de litigios en línea en materia de consumo conforme al Art. 14.1 del Reglamento (UE) 524/2013:",
                            1),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "TRLGDCU, LSSI",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "PC COMPONENTES Y MULTIMEDIA, S.L.U. , sociedad española, con NIF B73347494",
                            1),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "http://mundo.pccomponentes.com/politica-de-cookies/",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "https://www.pccomponentes.com/privacidad",
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
                            "Si el precio del producto ha variado, no se reembolsará la diferencia. 'Precio Prometido´ es nuestro compromiso contigo por el que si ves un artículo de marca (no de ASOS) más barato en otra página, igualaremos el precio. ",
                            1),
                        Delivery = new KeyValuePair<string, int>(
                            "Envio estandar: 4,95. Gratis si gastas más de 24,99. Envío \"Siguiente día laborable\": 9,95. Entrega a tu medida: 9,95. Estandar punto de recogida: 3,95. Al día siguiente punto de recogida: 9,95. Envío estandar gratis si gastas más de 24,99,; para el resto de envíos gratis si gastas más de 120. Opción de Envío Premier por solo 29,99 año.",
                            2),
                        Refund = new KeyValuePair<string, int>(
                            "El plazo de devolución son de hasta 28 días después de haberlo recibido. Rellena la hoja de devoluciones y elige la opción que más te convenga. Devolución gratis mediante Corres. Devolución gratis mediatne Mondial Relay.   Tanto los productos como su embaje deben devolverse en estado orginal, incluidas las etiquetas. Las devoluciones tardan 15 días en tramitarse, y el rembolso suele tardar entre 5 y 10 días laborables adicionales. ",
                            1),
                        Cancelation = new KeyValuePair<string, int>(
                            "No realizamos cambios, deberás hacer una devolución y realizar un nuevo pedido.",
                            2),
                        Guarantee = new KeyValuePair<string, int>(
                            "No hay garantía, en principio. En caso de que recibas un producto defectuoso, procederemos según corresponda a tramitar su reparación, sustitución, rebaja del precio o resolución del contrato. También responderemos de las faltas de conformidad que nos manifiestes en un plazo de dos años desde la entrega.",
                            3),
                        Jurisdiction = new KeyValuePair<string, int>(
                            "No específicada, según legislación general de consumidores. ",
                            4),
                        ApplicableLaw = new KeyValuePair<string, int>(
                            "Ley 3/2014  Ley General para la Defensa de Consumidores y Usuarios;  Ley 34/2002 de 11 de Julio “Ley de Servicios de  la Sociedad de la Información y del Comercio Electrónico",
                            1),
                        Responsibility = new KeyValuePair<string, int>(
                            "omos ASOS.com Limited (número de compañía 3584121), una compañía registrada en Inglaterra y Gales.",
                            3),
                        CookiesPolicy = new KeyValuePair<string, int>(
                            "https://www.asos.com/es/privacidad/",
                            1),
                        DataProtection = new KeyValuePair<string, int>(
                            "https://www.asos.com/es/descubre/marketing-terms-and-conditions/privacy-policy-cookies/",
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
