import React from 'react'
import "./LoginPage.scss"
import LoginForm from '../../components/LoginForm/LoginForm'

export default function LoginPage() {
  return (
    <div className='login-page'>
      <h1>HNH Library</h1>
      <LoginForm/>
    </div>
  )
}
