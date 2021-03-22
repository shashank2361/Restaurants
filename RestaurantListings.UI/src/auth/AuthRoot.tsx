import React from "react";
import { Route, Routes } from "react-router-dom";

import { Login } from "./Login";
import { Logout } from "./Logout";
import { Register } from "./Register";

export function AuthRoot() {
  return (
    <Routes>
      <Route path="login" element={<Login />} />
      <Route
        path="login-callback"
        element={<Login action="login-callback" />}
      />
      <Route path="register" element={<Register />} />
      <Route path="logout" element={<Logout />} />
      <Route
        path="logout-callback"
        element={<Logout action="logout-callback" />}
      />
    </Routes>
  );
}
