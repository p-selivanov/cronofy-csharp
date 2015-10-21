﻿using System;

namespace Cronofy
{
    public interface ICronofyOAuthClient
    {
        /// <summary>
        /// Gets the OAuth token from an authorization code provided by a
        /// successful authorization request.
        /// </summary>
        /// <param name="code">
        /// The authorization code provided by a successful authorization
        /// request, must not be empty.
        /// </param>
        /// <param name="redirectUri">
        /// The redirect URI provided for the authorization requests, must not
        /// be empty.
        /// </param>
        /// <returns>
        /// Returns an <see cref="OAuthToken"/> for the provided authorization
        /// code.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if <paramref name="code"/> or <paramref name="redirectUri"/>
        /// are null or empty.
        /// </exception>
        OAuthToken GetTokenFromCode(string code, string redirectUri);

        /// <summary>
        /// Gets the OAuth token from a refresh token retrieved with a previous
        /// OAuth token.
        /// </summary>
        /// <param name="refreshToken">
        /// The refresh token that can be used to retrieve a new
        /// <see cref="OAuthToken"/>, must not be empty.
        /// </param>
        /// <returns>
        /// Returns an <see cref="OAuthToken"/> for the provided refresh token.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if <paramref name="refreshToken"/> is null or empty.
        /// </exception>
        OAuthToken GetTokenFromRefreshToken(string refreshToken);
    }
}
