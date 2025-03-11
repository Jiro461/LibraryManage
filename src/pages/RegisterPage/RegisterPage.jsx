import React from 'react'
import "./RegisterPage.scss"
import RegisterForm from '../../components/RegisterForm/RegisterForm'

export default function RegisterPage() {
  return (
    <div className='register-page'>
      <h1>HNH Library</h1>
      <RegisterForm/>
    </div>
  )
}
