import { createContext, useContext } from "react";

import { AuthorizeService } from "./authService";

export interface IAuthContext {
  isAuthenticated: boolean;
  authService: AuthorizeService;
}

export const AuthContext = createContext<IAuthContext>({
  authService: null!,
  isAuthenticated: false,
});

export const useAuthContext = () => useContext(AuthContext);
