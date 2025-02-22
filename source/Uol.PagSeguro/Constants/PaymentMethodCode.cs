﻿// Copyright [2011] [PagSeguro Internet Ltda.]
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.


namespace Uol.PagSeguro.Domain
{
    /// <summary>
    /// Defines a list of known payment method codes.
    /// </summary>
    /// <remarks>
    /// This class is not an enum to enable the introduction of new payment method codes
    /// without breaking this version of the library.
    /// </remarks>
    public static class PaymentMethodCode
    {
        /// <summary>
        /// VISA
        /// </summary>
        public const int Visa = 101;

        /// <summary>
        /// Mastercard
        /// </summary>
        public const int Mastercard = 102;

        /// <summary>
        /// American Express
        /// </summary>
        public const int Amex = 103;

        /// <summary>
        /// Diners
        /// </summary>
        public const int Diners = 104;

        /// <summary>
        /// Hipercard
        /// </summary>
        public const int Hipercard = 105;

        /// <summary>
        /// Aura
        /// </summary>
        public const int Aura = 106;

        /// <summary>
        /// Elo
        /// </summary>
        public const int Elo = 107;

        /// <summary>
        /// PLENOCard
        /// </summary>
        public const int PlenoCard = 108;

        /// <summary>
        /// PersonalCard
        /// </summary>
        public const int PersonalCard = 109;

        /// <summary>
        /// JCB
        /// </summary>
        public const int Jcb = 110;

        /// <summary>
        /// Discover
        /// </summary>
        public const int Discover = 111;

        /// <summary>
        /// BrasilCard
        /// </summary>
        public const int BrasilCard = 112;

        /// <summary>
        /// FORTBRASIL
        /// </summary>
        public const int FortBrasil = 113;

        /// <summary>
        /// CARDBAN
        /// </summary>
        public const int CardBan = 114;

        /// <summary>
        /// VALECARD
        /// </summary>
        public const int ValeCard = 115;

        /// <summary>
        /// Cabal
        /// </summary>
        public const int Cabal = 116;

        /// <summary>
        /// Mais!
        /// </summary>
        public const int Mais = 117;

        /// <summary>
        /// Avista
        /// </summary>
        public const int Avista = 118;

        /// <summary>
        /// GrandCard
        /// </summary>
        public const int GrandCard = 119;

        /// <summary>
        /// Bradesco boleto
        /// </summary>
        public const int BradescoBoleto = 201;

        /// <summary>
        /// Santander boleto
        /// </summary>
        public const int SantanderBoleto = 202;

        /// <summary>
        /// Bradesco online transfer
        /// </summary>
        public const int BradescoOnlineTransfer = 301;

        /// <summary>
        /// Itau online transfer
        /// </summary>
        public const int ItauOnlineTransfer = 302;

        /// <summary>
        /// Unibanco online transfer
        /// </summary>
        public const int UnibancoOnlineTransfer = 303;

        /// <summary>
        /// Banco do Brasil online transfer
        /// </summary>
        public const int BancoBrasilOnlineTransfer = 304;

        /// <summary>
        /// Banco Real online transfer
        /// </summary>
        public const int RealOnlineTransfer = 305;

        /// <summary>
        /// Banrisul online transfer
        /// </summary>
        public const int BanrisulOnlineTransfer = 306;

        /// <summary>
        /// HSBC online transfer
        /// </summary>
        public const int HsbcOnlineTransfer = 307;

        /// <summary>
        /// PagSeguro account balance
        /// </summary>
        public const int PagSeguroBalance = 401;

        /// <summary>
        /// OiPaggo
        /// </summary>
        public const int OiPaggo = 501;

        /// <summary>
        /// Banco do Brasil direct deposit
        /// </summary>
        public const int BancoBrasilDirectDeposit = 701;
    }
}
