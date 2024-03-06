import React from "react"
import { logoutDiscussion } from "../../../store/actions/virtual-discussion/discussion-actions"

const Menu = () => {
  
  const handleShowDetailsClick = () => {

  }

  const handlePeopleClick = () => {

  }

  const handleDiscussionManagerClick = () => {

  }
  const handleSettingsClick = () => {

  }

  const handleLogoutCliick = () => {
    logoutDiscussion();
  }

  return (
    <>
      <button onClick={handleShowDetailsClick}>פרטי דיון</button>
      <button onClick={handlePeopleClick}>אנשים</button>
      <button onClick={handleDiscussionManagerClick}>מנהל דיון</button>
      <button onClick={handleSettingsClick}>הגדרות</button>
      <button onClick={handleLogoutCliick}>יציאה מהדיון</button>
    </>
  )
}

export default Menu
