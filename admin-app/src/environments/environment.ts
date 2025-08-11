import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Bestora.admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44335/',
    redirectUri: baseUrl,
    clientId: 'Bestora_App',
    responseType: 'code',
    scope: 'offline_access Bestora',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44335',
      rootNamespace: 'Bestora',
    },
  },
} as Environment;
