import React, { useEffect, useState } from 'react'
import {Outlet, Navigate, useNavigate} from "react-router-dom"

export default function PrivateRoutes() {
    const [loading, setLoading] = useState(true);
    const [isLogin, setIsLogin] = useState(false);

    const navigate = useNavigate();
  
    useEffect(() => {
        //call api
      const fetchUser = async () => {
        // const user = await api.fetchUser();
        const user = ""
  
        if (user) {
          setIsLogin(true);
          setLoading(false);
        } else {
          navigate("/login", { replace: true });
        }
      };
  
      fetchUser();
    }, [navigate]);
  
    if (loading)
      return (
        <p>
          Loading to <a href="/login">login</a> ...
        </p>
      );
  
    return isLogin ? (
      <>
        {/* <Header /> */}
        <Outlet />
      </>
    ) : (
      <Navigate to="/login" />
    );
}
