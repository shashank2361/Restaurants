import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { AuthenticationResultStatus, authService } from "./authService";

export interface LogoutProps {
  action?: "logout" | "logout-callback";
}

export function Logout(props: LogoutProps) {
  const { action = "logout" } = props;
  const navigate = useNavigate();

  useEffect(() => {
    async function logout(returnUrl?: string) {
      const state = { returnUrl };
      const isAuthenticated = await authService.isAuthenticated();
      if (isAuthenticated) {
        const result = await authService.signOut(state);
        switch (result.status) {
          case AuthenticationResultStatus.Redirect:
            break;
          case AuthenticationResultStatus.Success:
            navigateToReturnUrl(returnUrl);
            break;
          case AuthenticationResultStatus.Fail:
            break;
          default:
            throw new Error();
        }
      } else {
        navigateToReturnUrl("/");
      }
    }

    async function completeLogout() {
      const result = await authService.completeSignOut();
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
      case "logout":
        logout();
        break;
      case "logout-callback":
        completeLogout();
        break;
      default:
        throw Error();
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return null;
}
