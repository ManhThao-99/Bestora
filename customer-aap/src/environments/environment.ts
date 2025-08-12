import { Environment } from '@abp/ng.core';

const baseUrl = 'https://localhost:4201';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Bestora',
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
