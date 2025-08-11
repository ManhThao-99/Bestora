import { Environment } from '@abp/ng.core';

const baseUrl = 'https://163.223.210.4:5001';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Bestora.admin',
    logoUrl: '',
  },
  oAuthConfig: { 
    issuer: 'https://163.223.210.4:5000/',
    redirectUri: baseUrl,
    clientId: 'Bestora_App',
    responseType: 'code',
    scope: 'offline_access Bestora',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://163.223.210.4:5000',
      rootNamespace: 'Bestora',
    },
  },
} as Environment;
