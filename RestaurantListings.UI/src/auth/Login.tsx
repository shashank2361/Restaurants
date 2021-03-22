import { useEffect } from "react";
import { useLocation, useNavigate } from "react-router-dom";

import { useAuthContext } from "./authContext";
import { AuthenticationResultStatus } from "./authService";

export interface LoginProps {
  action?: "login" | "login-callback";
}

export function Login(props: LoginProps) {
  const { authService } = useAuthContext();
  const location = useLocation();
  const navigate = useNavigate();
  const { action = "login" } = props;

  useEffect(() => {
    async function login() {
      const result = await authService.signIn();
      if (result.status === AuthenticationResultStatus.Success) {
        navigateToReturnUrl();
      }
    }

    async function completeLogin() {
      const result = await authService.completeSignIn();
      switch (result.status) {
        case AuthenticationResultStatus.Redirect:
          break;
        case AuthenticationResultStatus.Success:
          navigateToReturnUrl();
          break;
        case AuthenticationResultStatus.Fail:
          break;
        default:
          throw Error();
      }
    }

    function navigateToReturnUrl(returnUrl?: string) {
      navigate(returnUrl || "/");
    }

    switch (action) {
      case "login":
        login();
        break;
      case "login-callback":
        completeLogin();
        break;
      default:
        throw Error();
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return null;
}
