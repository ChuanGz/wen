import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Angular',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44356/',
    redirectUri: baseUrl,
    clientId: 'Angular_App',
    responseType: 'code',
    scope: 'offline_access Angular',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44356',
      rootNamespace: 'Angular',
    },
  },
} as Environment;
