﻿using System.Security.Cryptography;

namespace IdentityStream.HttpMessageSigning {
    /// <summary>
    /// Convenience class for creating signature algorithms based on asymmetric algorithms.
    /// </summary>
    public static class SignatureAlgorithm {
        internal static readonly HashAlgorithmName DefaultHashAlgorithm = HashAlgorithmName.SHA512;

        /// <summary>
        /// Creates an <see cref="RSA"/> signature algorithm using the default <see cref="HashAlgorithm"/> (SHA512).
        /// </summary>
        /// <param name="rsa">The RSA algorithm instance.</param>
        /// <returns>An <see cref="RSA"/> signature algorithm.</returns>
        public static ISignatureAlgorithm Create(RSA rsa) =>
            Create(rsa, DefaultHashAlgorithm);

        /// <summary>
        /// Creates an <see cref="RSA"/> signature algorithm using the specified <paramref name="hashAlgorithm"/>.
        /// </summary>
        /// <param name="rsa">The RSA algorithm instance.</param>
        /// <param name="hashAlgorithm">The hash algorithm to use.</param>
        /// <returns>An <see cref="RSA"/> signature algorithm.</returns>
        public static ISignatureAlgorithm Create(RSA rsa, HashAlgorithmName hashAlgorithm) =>
            new RSASignatureAlgorithm(rsa, hashAlgorithm);

        /// <summary>
        /// Creates an <see cref="ECDsa"/> signature algorithm using the default <see cref="HashAlgorithm"/> (SHA512).
        /// </summary>
        /// <param name="ecdsa">The ECDsa algorithm instance.</param>
        /// <returns>An <see cref="ECDsa"/> signature algorithm.</returns>
        public static ISignatureAlgorithm Create(ECDsa ecdsa) =>
            Create(ecdsa, DefaultHashAlgorithm);

        /// <summary>
        /// Creates an <see cref="ECDsa"/> signature algorithm using the specified <paramref name="hashAlgorithm"/>.
        /// </summary>
        /// <param name="ecdsa">The ECDsa algorithm instance.</param>
        /// <param name="hashAlgorithm">The hash algorithm to use.</param>
        /// <returns>An <see cref="ECDsa"/> signature algorithm.</returns>
        public static ISignatureAlgorithm Create(ECDsa ecdsa, HashAlgorithmName hashAlgorithm) =>
            new ECDsaSignatureAlgorithm(ecdsa, hashAlgorithm);
    }
}
