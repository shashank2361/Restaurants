import React, { ReactNode, useEffect, useState } from "react";

import { authService } from "./authService";
import { AuthContext } from "./authContext";

export interface AuthProviderProps {
  children?: ReactNode;
}

export function AuthProvider(props: AuthProviderProps) {
  const [isAuthenticated, setAuthenticated] = useState(false);
  const [authReady, setAuthReady] = useState(false);

  useEffect(() => {
    async function initAuthManager() {
      await authService.ensureUserManagerInitialized();
       await checkAuthenticated();
      setAuthReady(true);
    }

    async function checkAuthenticated() {
      const authenticated = await authService.isAuthenticated();
      console.log(authenticated)
      setAuthenticated(authenticated);
    }

    let subscriptionId = authService.subscribe(checkAuthenticated);

    initAuthManager();

    return () => {
      authService.unsubscribe(subscriptionId);
    };
  }, []);

  if (!authReady) {
    return null;
  }

  return (
    <AuthContext.Provider
      value={{ isAuthenticated, authService: authService }}
      {...props}
    />
  );
}
